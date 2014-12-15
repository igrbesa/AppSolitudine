namespace WrapPanelHideControl
{
    partial class WrapPanelShowHide
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.splitContainerExplorer = new System.Windows.Forms.SplitContainer();
            this.explorerTree = new WindowsExplorer.ExplorerTree();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.btnShowHideLeftPanel = new System.Windows.Forms.Button();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.splitContainerExplorer.Panel1.SuspendLayout();
            this.splitContainerExplorer.Panel2.SuspendLayout();
            this.splitContainerExplorer.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.leftPanel);
            this.splitContainer.Panel1.Controls.Add(this.btnShowHideLeftPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerMain);
            this.splitContainer.Size = new System.Drawing.Size(442, 422);
            this.splitContainer.SplitterDistance = 230;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitContainer_SplitterMoving);
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.splitContainerExplorer);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(213, 420);
            this.leftPanel.TabIndex = 1;
            // 
            // splitContainerExplorer
            // 
            this.splitContainerExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerExplorer.Location = new System.Drawing.Point(0, 0);
            this.splitContainerExplorer.Name = "splitContainerExplorer";
            // 
            // splitContainerExplorer.Panel1
            // 
            this.splitContainerExplorer.Panel1.Controls.Add(this.explorerTree);
            // 
            // splitContainerExplorer.Panel2
            // 
            this.splitContainerExplorer.Panel2.Controls.Add(this.label1);
            this.splitContainerExplorer.Panel2.Controls.Add(this.listBoxFiles);
            this.splitContainerExplorer.Size = new System.Drawing.Size(213, 420);
            this.splitContainerExplorer.SplitterDistance = 107;
            this.splitContainerExplorer.TabIndex = 0;
            // 
            // explorerTree
            // 
            this.explorerTree.BackColor = System.Drawing.Color.White;
            this.explorerTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerTree.Location = new System.Drawing.Point(0, 0);
            this.explorerTree.Name = "explorerTree";
            this.explorerTree.SelectedPath = "C:\\Program Files\\Microsoft Visual Studio 11.0\\Common7\\IDE";
            this.explorerTree.ShowAddressbar = true;
            this.explorerTree.ShowMyDocuments = true;
            this.explorerTree.ShowMyFavorites = true;
            this.explorerTree.ShowMyNetwork = true;
            this.explorerTree.ShowToolbar = true;
            this.explorerTree.Size = new System.Drawing.Size(105, 418);
            this.explorerTree.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista datoteka:";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiles.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 24);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(100, 388);
            this.listBoxFiles.TabIndex = 0;
            // 
            // btnShowHideLeftPanel
            // 
            this.btnShowHideLeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowHideLeftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowHideLeftPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHideLeftPanel.Image = global::WrapPanelHideControl.Properties.Resources.left;
            this.btnShowHideLeftPanel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowHideLeftPanel.Location = new System.Drawing.Point(213, 0);
            this.btnShowHideLeftPanel.Name = "btnShowHideLeftPanel";
            this.btnShowHideLeftPanel.Size = new System.Drawing.Size(15, 420);
            this.btnShowHideLeftPanel.TabIndex = 0;
            this.btnShowHideLeftPanel.UseCompatibleTextRendering = true;
            this.btnShowHideLeftPanel.UseVisualStyleBackColor = false;
            this.btnShowHideLeftPanel.Click += new System.EventHandler(this.btnShowHideLeftPanel_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Size = new System.Drawing.Size(208, 422);
            this.splitContainerMain.SplitterDistance = 101;
            this.splitContainerMain.TabIndex = 0;
            // 
            // WrapPanelShowHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "WrapPanelShowHide";
            this.Size = new System.Drawing.Size(442, 422);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.splitContainerExplorer.Panel1.ResumeLayout(false);
            this.splitContainerExplorer.Panel2.ResumeLayout(false);
            this.splitContainerExplorer.Panel2.PerformLayout();
            this.splitContainerExplorer.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnShowHideLeftPanel;
        public System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.SplitContainer splitContainerExplorer;
        private WindowsExplorer.ExplorerTree explorerTree;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBoxFiles;


    }
}
