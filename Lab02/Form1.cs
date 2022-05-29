using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel;

namespace DesktopApp
{
    public partial class Form1 : Form
    {

        Storage data = Storage.Instance;

        LittleOptions options = new LittleOptions();

        public Form1()
        {
            InitializeComponent();
            allViewer1.Bind = data;
        }

        private void OnOptions_Click(object sender, EventArgs e)
        {
            options.ShowDialog();
            allViewer1.ResetBindingSourses();
            //Little
        }

        private void OpenLast_Click(object sender, EventArgs e)
        {
            Storage.Instance.LoadLast();
            allViewer1.ResetBindingSourses();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            Storage.Instance.Load();
            allViewer1.ResetBindingSourses();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            Storage.Instance.SaveLast();
        }

        private void SaceFileAs_Click(object sender, EventArgs e)
        {
            Storage.Instance.Save();
        }

        private void ConvertToWord_Click(object sender, EventArgs e)
        {
            Storage.Instance.ConvertToWord();
        }

        private void ConvertToExcel_Click(object sender, EventArgs e)
        {
            Storage.Instance.ConvertToExcel();
        }
    }
}
