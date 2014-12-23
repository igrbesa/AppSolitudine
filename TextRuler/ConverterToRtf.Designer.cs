namespace TextRuler
{
    partial class ConverterToRtf
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel2 = new System.Windows.Forms.RibbonLabel();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnConvert = new System.Windows.Forms.Button();
            this.checkedListBoxDoc = new System.Windows.Forms.CheckedListBox();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbPath
            // 
            this.txbPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPath.Location = new System.Drawing.Point(12, 12);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(647, 20);
            this.txbPath.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(665, 9);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(27, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(12, 38);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.checkedListBoxDoc);
            this.splitContainer.Size = new System.Drawing.Size(680, 393);
            this.splitContainer.SplitterDistance = 315;
            this.splitContainer.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConvert.Location = new System.Drawing.Point(15, 439);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(127, 31);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Pretvori";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // checkedListBoxDoc
            // 
            this.checkedListBoxDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxDoc.FormattingEnabled = true;
            this.checkedListBoxDoc.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxDoc.Name = "checkedListBoxDoc";
            this.checkedListBoxDoc.Size = new System.Drawing.Size(313, 391);
            this.checkedListBoxDoc.TabIndex = 0;
            // 
            // ConverterToRtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 482);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txbPath);
            this.Name = "ConverterToRtf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretvarač Doc i docx foramta u rtf";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.RibbonLabel ribbonLabel2;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckedListBox checkedListBoxDoc;
    }
}