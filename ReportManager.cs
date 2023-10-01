using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftReportingDemo
{
    internal class ReportManager
    {
        private ReportViewer rp {  get; set; }
        private ReportParameter parameter { get; set; }

        public ReportManager(ReportViewer _reportViewer)
        {
            rp = _reportViewer;
            parameter = new ReportParameter();
        }

        public void setParameter(string _name, string _value)
        {
            parameter.Name = _name;
            parameter.Values.Add(_value);

            rp.LocalReport.SetParameters(parameter);
        }

        public void setData<T>(string _name, List<T> _data)
        {
            var rds = new ReportDataSource();
            rds.Name = _name;
            rds.Value = _data;

            rp.LocalReport.DataSources.Add(rds);
        }

        public void viewReport()
        {
           rp.RefreshReport();
        }
    }
}
