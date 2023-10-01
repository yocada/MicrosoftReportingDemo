using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftReportingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bLaunchReport.Click += BLaunchReport_Click;
        }

        private void BLaunchReport_Click(object sender, EventArgs e)
        {
            var rm = new ReportManager(rvDemo);

            rm.setParameter("SubTitle", txtSubTitle.Text);

            rm.setData("DSSalesLine", SalesLineDS.getSalesLines());

            rm.viewReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.rvDemo.RefreshReport();
        }
    }
}
