using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextRuler
{
    public partial class ConverterToRtf : Form
    {
        private string path;

        public string Path
        {
            set { path = value; }
        }

        public ConverterToRtf()
        {
            InitializeComponent();

            Inits();
        }

        private void Inits()
        {
            splitContainer.SplitterDistance = (int) splitContainer.Width / 2;
            
        }

        public void Populate(string path)
        {
            this.path = path;
            txbPath.Text = path;

            string[] files = Directory.GetFiles(path, "*.doc*", SearchOption.AllDirectories);

            for(int i = 0; i< files.Length; i++){
                checkedListBoxDoc.Items.Add(System.IO.Path.GetFileName(files[i]));
                checkedListBoxDoc.SetItemChecked(i, true);
            }

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
