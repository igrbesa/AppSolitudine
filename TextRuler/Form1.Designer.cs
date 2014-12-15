namespace TextRuler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wrapPanelShowHide = new WrapPanelHideControl.WrapPanelShowHide();
            this.SuspendLayout();
            // 
            // wrapPanelShowHide
            // 
            this.wrapPanelShowHide.BackgrounColor = System.Drawing.Color.Empty;
            this.wrapPanelShowHide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wrapPanelShowHide.Location = new System.Drawing.Point(0, 143);
            this.wrapPanelShowHide.Name = "wrapPanelShowHide";
            this.wrapPanelShowHide.Size = new System.Drawing.Size(745, 419);
            this.wrapPanelShowHide.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(745, 562);
            this.Controls.Add(this.wrapPanelShowHide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WrapPanelHideControl.WrapPanelShowHide wrapPanelShowHide;








    }
}