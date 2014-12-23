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
            this.ribbonMenu = new System.Windows.Forms.Ribbon();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonBkndColor = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRibbonColor = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonConverter = new System.Windows.Forms.RibbonButton();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // wrapPanelShowHide
            // 
            this.wrapPanelShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapPanelShowHide.BackgrounColor = System.Drawing.Color.Empty;
            this.wrapPanelShowHide.Location = new System.Drawing.Point(0, 135);
            this.wrapPanelShowHide.Name = "wrapPanelShowHide";
            this.wrapPanelShowHide.Size = new System.Drawing.Size(745, 427);
            this.wrapPanelShowHide.TabIndex = 0;
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.Minimized = false;
            this.ribbonMenu.Name = "ribbonMenu";
            // 
            // 
            // 
            this.ribbonMenu.OrbDropDown.BorderRoundness = 8;
            this.ribbonMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.OrbDropDown.Name = "";
            this.ribbonMenu.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbonMenu.OrbDropDown.TabIndex = 0;
            this.ribbonMenu.OrbImage = null;
            // 
            // 
            // 
            this.ribbonMenu.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbonMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMenu.Size = new System.Drawing.Size(745, 129);
            this.ribbonMenu.TabIndex = 1;
            this.ribbonMenu.Tabs.Add(this.ribbonTab1);
            this.ribbonMenu.Tabs.Add(this.ribbonTab2);
            this.ribbonMenu.Tabs.Add(this.ribbonTab3);
            this.ribbonMenu.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonMenu.Text = "ribbonMenu";
            this.ribbonMenu.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween;
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Text = "Stil";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonButtonBkndColor);
            this.ribbonPanel3.Items.Add(this.ribbonButtonRibbonColor);
            this.ribbonPanel3.Text = "Boja";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Panels.Add(this.ribbonPanel4);
            this.ribbonTab3.Text = "Napredno";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ButtonMoreEnabled = false;
            this.ribbonPanel4.ButtonMoreVisible = false;
            this.ribbonPanel4.Items.Add(this.ribbonButtonConverter);
            this.ribbonPanel4.Text = "";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButtonBkndColor
            // 
            this.ribbonButtonBkndColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBkndColor.Image")));
            this.ribbonButtonBkndColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonBkndColor.SmallImage")));
            this.ribbonButtonBkndColor.Text = "Pozadina";
            // 
            // ribbonButtonRibbonColor
            // 
            this.ribbonButtonRibbonColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRibbonColor.Image")));
            this.ribbonButtonRibbonColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRibbonColor.SmallImage")));
            this.ribbonButtonRibbonColor.Text = "Izbornik";
            // 
            // ribbonButtonConverter
            // 
            this.ribbonButtonConverter.Image = global::TextRuler.Properties.Resources.Converter;
            this.ribbonButtonConverter.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonConverter.SmallImage")));
            this.ribbonButtonConverter.Text = "Pretvarač";
            this.ribbonButtonConverter.Click += new System.EventHandler(this.ribbonButtonConverter_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "Home";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(745, 562);
            this.Controls.Add(this.ribbonMenu);
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
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.Ribbon ribbonMenu;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton ribbonButtonBkndColor;
        private System.Windows.Forms.RibbonButton ribbonButtonRibbonColor;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton ribbonButtonConverter;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton2;








    }
}