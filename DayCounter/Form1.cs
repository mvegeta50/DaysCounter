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
        private Configuration _config = null;
        private ExeConfigurationFileMap _fileMap = null;
        #endregion


        public DayCounter()
        {
            InitializeComponent();
    
            InitializeConfigFileMap();

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
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
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                //read data from configurationmanager
                if (_config != null)
                {
                    _setFromDate = _config.AppSettings.Settings["startingDate"].Value;
                    _titel = _config.AppSettings.Settings["lblTitel"].Value;
                    if (string.IsNullOrEmpty(_setFromDate) || _reset)
                    {
                        InvokePanelShow(pnlSetDate);
                    }
                    else
                    {
                        InvokePanelShow(pnlShowDaysInfo);
                        ShowTimeSpan(_setFromDate);
                    }
                }
            }
        }

        private void ShowTimeSpan(string startingDay)
        {
            if (DateTime.TryParse(startingDay, out DateTime startDatetime))
            {
                TimeSpan timespan = DateTime.Now - startDatetime;
                string timeSpanFormatted = String.Format("{0:0.00000} days and counting", timespan.TotalDays);
                string startingDayFormatted = String.Format("since {0} ", startingDay);

                //Invoke label title
                InvokeLabel(_titel, lblTitel);
                //Invoke label days
                InvokeLabel(timeSpanFormatted, lblDays);
                //Invoke label since date
                InvokeLabel(startingDayFormatted, lblDateSince);
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
            Action action2 = () => panel.Show();
            panel.Invoke(action2);
        }


        private void btnSetStartingDate_Click(object sender, EventArgs e)
        {

            //Set datetime to midnight hour
            DateTime startingDate = datePicker1.Value;
            string modifiedStartingDate = new DateTime(startingDate.Year, startingDate.Month, startingDate.Day, 0, 0, 0).ToString();


            _config = ConfigurationManager.OpenMappedExeConfiguration(_fileMap, ConfigurationUserLevel.None);
            _config.AppSettings.Settings.Remove("startingDate");
            _config.AppSettings.Settings.Add("startingDate", modifiedStartingDate);

            _config.AppSettings.Settings.Remove("lblTitel");
            _config.AppSettings.Settings.Add("lblTitel", txtBoxSetLabel.Text);
            _config.Save();


            _reset = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _reset = true;
        }
    }
}
