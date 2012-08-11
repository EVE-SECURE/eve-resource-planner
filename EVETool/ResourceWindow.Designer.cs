namespace EVETool
{
    partial class ResourceWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceWindow));
            this.ResourcePanel = new System.Windows.Forms.Panel();
            this.NewIndustryInter = new System.Windows.Forms.Button();
            this.SetSize = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ResourcePanel
            // 
            resources.ApplyResources(this.ResourcePanel, "ResourcePanel");
            this.ResourcePanel.Name = "ResourcePanel";
            // 
            // NewIndustryInter
            // 
            resources.ApplyResources(this.NewIndustryInter, "NewIndustryInter");
            this.NewIndustryInter.BackgroundImage = Properties.Resources._33_128_2;
            this.NewIndustryInter.Name = "NewIndustryInter";
            this.NewIndustryInter.UseVisualStyleBackColor = true;
            this.NewIndustryInter.Click += new System.EventHandler(this.NewIndustryInter_Click);
            // 
            // SetSize
            // 
            resources.ApplyResources(this.SetSize, "SetSize");
            this.SetSize.Name = "SetSize";
            // 
            // ResourceWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.ResourcePanel);
            this.Controls.Add(this.NewIndustryInter);
            this.Controls.Add(this.SetSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ResourceWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button NewIndustryInter;
        private System.Windows.Forms.Panel ResourcePanel;
        private System.Windows.Forms.Panel SetSize;
    }
}

