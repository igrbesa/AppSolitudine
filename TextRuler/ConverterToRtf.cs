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
        private string[] fileNames;

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

            fileNames = Directory.GetFiles(path, "*.doc*", SearchOption.AllDirectories);

            for (int i = 0; i < fileNames.Length; i++)
            {
                checkedListBoxDoc.Items.Add(System.IO.Path.GetFileName(fileNames[i]));
                checkedListBoxDoc.SetItemChecked(i, true);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //make new folder and change extension of it
            string directoryNameConverted = this.path + " - rtf Converted";
            if (!Directory.Exists(directoryNameConverted))
                Directory.CreateDirectory(directoryNameConverted);
            else
                MessageBox.Show("Directory allready exists");

            foreach (string file in fileNames)
            {
                
                FileInfo f = new FileInfo(file);
                f.CopyTo(directoryNameConverted + @"\\"+ System.IO.Path.GetFileNameWithoutExtension(file) + ".rtf", true);
                
                //File.Copy(file, directoryNameConverted);
            }
            
        }
    }
}
