using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestingExcelImport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            CustomImport.ImportData Import = new CustomImport.ImportData();
            if (txtFilePath.Text != string.Empty)
            {
                Import.ImportDataFromExcel(txtFilePath.Text);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog FileBrowser = new System.Windows.Forms.OpenFileDialog();
            FileBrowser.ShowDialog();
            txtFilePath.Text = FileBrowser.FileName;
        }

        private void btnHRAnalysis_Click(object sender, EventArgs e)
        {
            CustomImport.ImportData Import = new CustomImport.ImportData();
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\git\WinApps\ANA3\");

            string logfilepath = @"C:\HR_cleanup.txt";
            Import.ClearFile(logfilepath);
            Import.WalkDirectories(dirInfo, logfilepath);
        }

    }
}
