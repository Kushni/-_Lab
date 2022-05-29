using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel;

namespace DesktopApp
{
    public partial class LittleOptions : Form
    {
        public LittleOptions()
        {
            InitializeComponent();
            checkBox1.Checked = Storage.Instance.cascadeDelete = ReadConfig();
            if (checkBox1.Checked) this.Text = "True";
            else this.Text = "False";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Storage.Instance.cascadeDelete = checkBox1.Checked;
            WriteConfig();
        }

        private bool ReadConfig()
        {
            using (StreamReader streamReader = new StreamReader("Config.txt"))
            {
                if (streamReader.ReadLine() != "0") return true;
                else return false;
            }
        }

        private void WriteConfig()
        {
            using (StreamWriter streamWriter = new StreamWriter("Config.txt", false))
            {
                if (checkBox1.Checked) streamWriter.Write('1');
                else streamWriter.Write('0');
            }
        }

        private void radioButtonBinary_CheckedChanged(object sender, EventArgs e)
        {
            Storage.Instance.saveFormat = Storage.SaveFormat.bin;
        }

        private void radioButtonXml_CheckedChanged(object sender, EventArgs e)
        {
            Storage.Instance.saveFormat = Storage.SaveFormat.xml;
        }

        private void radioButtonJson_CheckedChanged(object sender, EventArgs e)
        {
            Storage.Instance.saveFormat = Storage.SaveFormat.json;
        }
    }
}
