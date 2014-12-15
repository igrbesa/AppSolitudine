using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextRuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //wrapPanelShowHide1.AddToLeftPanel(new WindowsExplorer.ExplorerTree());
            //wrapPanelShowHide1.leftPanel.Controls.Add(new WindowsExplorer.ExplorerTree());
            wrapPanelShowHide.BackgrounColor = Color.Pink;
            //wrapPanelShowHide1.listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            wrapPanelShowHide.ItemSelectionChanged += wrapPanelShowHide1_ItemSelectionChanged;
            
        }

        void wrapPanelShowHide1_ItemSelectionChanged(object sender, EventArgs e)
        {

        }



        void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = this.wrapPanelShowHide.SelectedPath;
            string file = this.wrapPanelShowHide.SelectedFile;
            IList<string> files = wrapPanelShowHide.ListFiles;
        }       
    }
}
