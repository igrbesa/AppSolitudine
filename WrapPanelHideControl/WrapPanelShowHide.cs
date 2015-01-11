using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace WrapPanelHideControl
{
    public partial class WrapPanelShowHide : UserControl
    {

        private int leftPanelWidth;
        private Color backgrounColor;
        public event EventHandler ItemSelectionChanged
        {
            add
            {
                this.listBoxFiles.SelectedIndexChanged += value;
            }

            remove
            {
                this.listBoxFiles.SelectedIndexChanged -= value;
            }
        }     

        public IList<string> ListFiles
        {
            get { return this.listBoxFiles.Items.Cast<string>().ToList(); }
            //set { listFiles = value; }
        }

        public String SelectedFile
        {
            get { return (string)this.listBoxFiles.SelectedItem; }
            //set { selectedFile = value; }
        }

        public String SelectedPath
        {
            get { return this.explorerTree.SelectedPath; }
            set { this.explorerTree.SelectedPath = value; }
        }

        public Color BackgrounColor
        {
            get { return backgrounColor; }
            set { backgrounColor = value; setBackGroundColor(); }
        }


        public WrapPanelShowHide()
        {
            InitializeComponent();

            InitialParameters();
        }

        private void InitialParameters()
        {
            leftPanelWidth = (int)(this.Width / 3);
            this.splitContainer.SplitterDistance = leftPanelWidth;
            this.splitContainer.BackColor = BackgrounColor;
            this.btnShowHideLeftPanel.BackColor = BackgrounColor;
            this.splitContainerExplorer.SplitterDistance = (int)this.leftPanel.Width / 2;
            this.listBoxFiles.Items.Clear();
            this.listBoxFiles.BackColor = BackgrounColor;
            this.splitContainerMain.SplitterDistance =  (int) this.splitContainerMain.Width / 3;
            this.explorerTree.BackColor = BackgrounColor;
            //explorerTree
            //this.explorerTree.ShowToolbar = false;
            this.explorerTree.PathChanged += explorerTree_PathChanged;
        }

        private void setBackGroundColor()
        {
            this.splitContainer.BackColor = BackgrounColor;
            this.btnShowHideLeftPanel.BackColor = BackgrounColor;
            this.listBoxFiles.BackColor = BackgrounColor;
            this.explorerTree.BackColor = BackgrounColor;
        }

        void explorerTree_PathChanged(object sender, EventArgs e)
        {
            populateItemListBox();
        }

        private void populateItemListBox()
        {
            this.listBoxFiles.Items.Clear();
            string path = this.explorerTree.SelectedPath;
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo file in dir.GetFiles())
            {
                this.listBoxFiles.Items.Add(file.Name);
            }
        }

        private void btnShowHideLeftPanel_Click(object sender, EventArgs e)
        {
            if (this.splitContainer.SplitterDistance <= this.btnShowHideLeftPanel.Width + 15)
                ShowPanel();
            else
                HidePanel();
        }

        public void HidePanel()
        {
            this.leftPanelWidth = this.splitContainer.SplitterDistance;
            this.splitContainer.SplitterDistance = btnShowHideLeftPanel.Width;
            this.btnShowHideLeftPanel.Image = Properties.Resources.right;
            this.leftPanel.Hide();
        }

        public void ShowPanel()
        {
            this.splitContainer.SplitterDistance = leftPanelWidth;
            this.btnShowHideLeftPanel.Image = Properties.Resources.left;
            this.leftPanel.Show();
        }

        private void splitContainer_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            changeImageOnButton();
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            changeImageOnButton();
        }

        private void changeImageOnButton()
        {
            if (this.splitContainer.SplitterDistance <= this.btnShowHideLeftPanel.Width + 10)
                this.btnShowHideLeftPanel.Image = Properties.Resources.right;
            else
                this.btnShowHideLeftPanel.Image = Properties.Resources.left;
        }


        public void AddToLeftPanel(Control control)
        {
            this.splitContainerMain.Panel1.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        public void AddToRightPanel(Control control)
        {
            this.splitContainerMain.Panel2.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        public void RefreshListBox()
        {
            populateItemListBox();
        }
    }
}
