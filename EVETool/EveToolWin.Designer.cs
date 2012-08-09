namespace EVETool
{
    partial class EveToolWin
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
            this.ResourcePanel = new System.Windows.Forms.Panel();
            this.NewIndustryInter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResourcePanel
            // 
            this.ResourcePanel.Location = new System.Drawing.Point(12, 82);
            this.ResourcePanel.Name = "ResourcePanel";
            this.ResourcePanel.Size = new System.Drawing.Size(850, 339);
            this.ResourcePanel.TabIndex = 1;
            // 
            // NewIndustryInter
            // 
            this.NewIndustryInter.BackgroundImage = global::EVETool.Properties.Resources._33_128_2;
            this.NewIndustryInter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewIndustryInter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewIndustryInter.Location = new System.Drawing.Point(12, 12);
            this.NewIndustryInter.Name = "NewIndustryInter";
            this.NewIndustryInter.Size = new System.Drawing.Size(64, 64);
            this.NewIndustryInter.TabIndex = 0;
            this.NewIndustryInter.UseVisualStyleBackColor = true;
            this.NewIndustryInter.Click += new System.EventHandler(this.NewIndustryInter_Click);
            // 
            // EveToolWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(875, 433);
            this.Controls.Add(this.ResourcePanel);
            this.Controls.Add(this.NewIndustryInter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EveToolWin";
            this.Text = "Resource Planner";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button NewIndustryInter;
        private System.Windows.Forms.Panel ResourcePanel;
    }
}

