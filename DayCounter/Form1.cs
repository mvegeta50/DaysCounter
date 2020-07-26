using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysCounterUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
          
        }
        public void CountDays()
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                string startingDay = ConfigurationManager.AppSettings["startingDate"];

                if (DateTime.TryParse(startingDay, out DateTime startDatetime))
                {
                    TimeSpan timespan = DateTime.Now - startDatetime;
                    string timeSpanEyeFriendly= String.Format("{0:0.00000} days and counting", timespan.TotalDays);

                    InvokeLabel(timeSpanEyeFriendly);
                }
                else
                {
                    InvokeLabel("startingDate in app.config is not set to a valid date"); 
                }
            }
        }

        private void InvokeLabel(string tekst)
        {
            Action action = () => lblDays.Text = tekst;
            lblDays.Invoke(action);
        }
    }
}
