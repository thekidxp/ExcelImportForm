using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
