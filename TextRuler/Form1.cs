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

            Inits();
            //wrapPanelShowHide1.AddToLeftPanel(new WindowsExplorer.ExplorerTree());
            //wrapPanelShowHide1.leftPanel.Controls.Add(new WindowsExplorer.ExplorerTree());
            //TODO: postaviti opcionalno u menu-ju
            wrapPanelShowHide.BackgrounColor = Color.Pink;
            //wrapPanelShowHide1.listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;

            
            
        }

        private void Inits()
        {
            wrapPanelShowHide.ItemSelectionChanged += wrapPanelShowHide1_ItemSelectionChanged;
            wrapPanelShowHide.AddToRightPanel(new AdvancedTextEditorControl.AdvancedTextEditor());

            
        }

        void wrapPanelShowHide1_ItemSelectionChanged(object sender, EventArgs e)
        {
            String file = wrapPanelShowHide.SelectedPath + wrapPanelShowHide.SelectedFile;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ribbonButtonConverter_Click(object sender, EventArgs e)
        {
            ConverterToRtf converter = new ConverterToRtf();
            converter.Populate(wrapPanelShowHide.SelectedPath);
            converter.Show();
        }
    
    }
}
