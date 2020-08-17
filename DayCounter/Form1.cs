using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysCounterUI
{
    public partial class DayCounter : Form
    {
        #region private fields
        private string _titel;
        private string _setFromDate;
        private bool _reset = false;
        private ExeConfigurationFileMap _fileMap = null;
        private Configuration _config = null;
        #endregion


        public DayCounter()
        {
            InitializeComponent();

            InitializeConfigFileMap();

            ShowSetDatePanel();

            StartShowDaysInfo();
        }

        private void ShowSetDatePanel()
        {
            if (string.IsNullOrEmpty(_setFromDate))
            {
                pnlSetDate.BringToFront();
            }
        }

        private void InitializeConfigFileMap()
        {
            //Initialize appdata location
            string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPathConfigFile = Path.Combine(app_data, "DaysCounter", "DaysCounterUI.exe.config");
            _fileMap = new ExeConfigurationFileMap();
            _fileMap.ExeConfigFilename = fullPathConfigFile;

            _config = ConfigurationManager.OpenMappedExeConfiguration(_fileMap, ConfigurationUserLevel.None);
            if (_config.AppSettings.Settings["startingDate"] != null)
            {
                _setFromDate = _config.AppSettings.Settings["startingDate"].Value;
                if (DateTime.TryParse(_setFromDate, out DateTime result))
                {
                    datePicker1.Value = result;
                };
            }
            if (_config.AppSettings.Settings["lblTitel"] != null)
            {
                _titel = _config.AppSettings.Settings["lblTitel"].Value;
                txtSetTitel.Text = _titel;
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ShowTimeSpan();
        }

        private void ShowTimeSpan()
        {
            while (!_reset)
            {
                if (DateTime.TryParse(_setFromDate, out DateTime startDatetime))
                {
                    TimeSpan timespan = DateTime.Now - startDatetime;
                    string timeSpanFormatted = String.Format("{0:0.00000} days and counting", timespan.TotalDays);
                    string setFromDateFormatted = String.Format("since {0} ", _setFromDate);

                    //Invoke label title
                    InvokeLabel(_titel, lblTitel);
                    //Invoke label days
                    InvokeLabel(timeSpanFormatted, lblDays);
                    //Invoke label since date
                    InvokeLabel(setFromDateFormatted, lblDateSince);
                }
            }
        }

        private void InvokeLabel(string tekst, Label labelToInvoke)
        {
            Action action = () => labelToInvoke.Text = tekst;
            labelToInvoke.Invoke(action);

        }
        private void InvokePanelShow(Panel panel)
        {
            Action action1 = () => panel.BringToFront();
            panel.Invoke(action1);
        }


        private void btnSetStartingDate_Click(object sender, EventArgs e)
        {

            //Set datetime to midnight hour
            DateTime startingDate = datePicker1.Value;
            string modifiedStartingDate = new DateTime(startingDate.Year, startingDate.Month, startingDate.Day, 0, 0, 0).ToString();
            PersistConfigFile(modifiedStartingDate);

            _reset = false;
            StartShowDaysInfo();
        }

        private void PersistConfigFile(string modifiedStartingDate)
        {
            _config = ConfigurationManager.OpenMappedExeConfiguration(_fileMap, ConfigurationUserLevel.None);
            _config.AppSettings.Settings.Remove("startingDate");
            _config.AppSettings.Settings.Add("startingDate", modifiedStartingDate);

            _config.AppSettings.Settings.Remove("lblTitel");
            _config.AppSettings.Settings.Add("lblTitel", txtSetTitel.Text);
            _config.Save();
            _setFromDate = modifiedStartingDate;
            _titel = txtSetTitel.Text;
        }

        private void StartShowDaysInfo()
        {
            BringPanelToFront(pnlShowDaysInfo);
            RunWorker();
        }

        private void BringPanelToFront(Panel panel)
        {
            panel.BringToFront();
        }
        private void RunWorker()
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _reset = true;
            pnlSetDate.BringToFront();
        }
    }
}
