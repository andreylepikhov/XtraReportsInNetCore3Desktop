using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace SimpleWinForms
{
    public partial class Form1 : Form {
        private Button button1;
        private Button button2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            var report = new WindowsFormsApp1.XtraReport1();
            var rd = new DevExpress.XtraReports.UI.ReportDesignTool(report);
            rd.ShowDesignerDialog();
        }

        private void Button2_Click(object sender, EventArgs e) {
            var report = new WindowsFormsApp1.XtraReport1();
            report.ShowPreviewDialog();
        }
    }
}
