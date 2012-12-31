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
            this.Temperate = new System.Windows.Forms.PictureBox();
            this.Storm = new System.Windows.Forms.PictureBox();
            this.Plasma = new System.Windows.Forms.PictureBox();
            this.Oceanic = new System.Windows.Forms.PictureBox();
            this.Lava = new System.Windows.Forms.PictureBox();
            this.Ice = new System.Windows.Forms.PictureBox();
            this.Gas = new System.Windows.Forms.PictureBox();
            this.Barren = new System.Windows.Forms.PictureBox();
            this.NewIndustryInter = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Temperate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plasma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oceanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barren)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResourcePanel
            // 
            this.ResourcePanel.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            resources.ApplyResources(this.ResourcePanel, "ResourcePanel");
            this.ResourcePanel.Name = "ResourcePanel";
            // 
            // Temperate
            // 
            resources.ApplyResources(this.Temperate, "Temperate");
            this.Temperate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Temperate.Image = global::EVETool.Properties.Resources.Temperate;
            this.Temperate.Name = "Temperate";
            this.Temperate.TabStop = false;
            this.Temperate.Click += new System.EventHandler(this.Temperate_Click);
            this.Temperate.MouseEnter += new System.EventHandler(this.Temperate_MouseEnter);
            this.Temperate.MouseLeave += new System.EventHandler(this.Temperate_MouseLeave);
            // 
            // Storm
            // 
            resources.ApplyResources(this.Storm, "Storm");
            this.Storm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Storm.Image = global::EVETool.Properties.Resources.Storm;
            this.Storm.Name = "Storm";
            this.Storm.TabStop = false;
            this.Storm.Click += new System.EventHandler(this.Storm_Click);
            this.Storm.MouseEnter += new System.EventHandler(this.Storm_MouseEnter);
            this.Storm.MouseLeave += new System.EventHandler(this.Storm_MouseLeave);
            // 
            // Plasma
            // 
            resources.ApplyResources(this.Plasma, "Plasma");
            this.Plasma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Plasma.Image = global::EVETool.Properties.Resources.Plasma;
            this.Plasma.Name = "Plasma";
            this.Plasma.TabStop = false;
            this.Plasma.Click += new System.EventHandler(this.Plasma_Click);
            this.Plasma.MouseEnter += new System.EventHandler(this.Plasma_MouseEnter);
            this.Plasma.MouseLeave += new System.EventHandler(this.Plasma_MouseLeave);
            // 
            // Oceanic
            // 
            resources.ApplyResources(this.Oceanic, "Oceanic");
            this.Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Oceanic.Image = global::EVETool.Properties.Resources.Oceanic;
            this.Oceanic.Name = "Oceanic";
            this.Oceanic.TabStop = false;
            this.Oceanic.Click += new System.EventHandler(this.Oceanic_Click);
            this.Oceanic.MouseEnter += new System.EventHandler(this.Oceanic_MouseEnter);
            this.Oceanic.MouseLeave += new System.EventHandler(this.Oceanic_MouseLeave);
            // 
            // Lava
            // 
            resources.ApplyResources(this.Lava, "Lava");
            this.Lava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lava.Image = global::EVETool.Properties.Resources.Lava;
            this.Lava.Name = "Lava";
            this.Lava.TabStop = false;
            this.Lava.Click += new System.EventHandler(this.Lava_Click);
            this.Lava.MouseEnter += new System.EventHandler(this.Lava_MouseEnter);
            this.Lava.MouseLeave += new System.EventHandler(this.Lava_MouseLeave);
            // 
            // Ice
            // 
            resources.ApplyResources(this.Ice, "Ice");
            this.Ice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ice.Image = global::EVETool.Properties.Resources.Ice;
            this.Ice.Name = "Ice";
            this.Ice.TabStop = false;
            this.Ice.Click += new System.EventHandler(this.Ice_Click);
            this.Ice.MouseEnter += new System.EventHandler(this.Ice_MouseEnter);
            this.Ice.MouseLeave += new System.EventHandler(this.Ice_MouseLeave);
            // 
            // Gas
            // 
            resources.ApplyResources(this.Gas, "Gas");
            this.Gas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Gas.Image = global::EVETool.Properties.Resources.Gas;
            this.Gas.Name = "Gas";
            this.Gas.TabStop = false;
            this.Gas.Click += new System.EventHandler(this.Gas_Click);
            this.Gas.MouseEnter += new System.EventHandler(this.Gas_MouseEnter);
            this.Gas.MouseLeave += new System.EventHandler(this.Gas_MouseLeave);
            // 
            // Barren
            // 
            resources.ApplyResources(this.Barren, "Barren");
            this.Barren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Barren.Image = global::EVETool.Properties.Resources.Barren;
            this.Barren.Name = "Barren";
            this.Barren.TabStop = false;
            this.Barren.Click += new System.EventHandler(this.Barren_Click);
            this.Barren.MouseEnter += new System.EventHandler(this.Barren_MouseEnter);
            this.Barren.MouseLeave += new System.EventHandler(this.Barren_MouseLeave);
            // 
            // NewIndustryInter
            // 
            this.NewIndustryInter.BackgroundImage = global::EVETool.Properties.Resources._33_128_2;
            resources.ApplyResources(this.NewIndustryInter, "NewIndustryInter");
            this.NewIndustryInter.Name = "NewIndustryInter";
            this.NewIndustryInter.UseVisualStyleBackColor = true;
            this.NewIndustryInter.Click += new System.EventHandler(this.NewIndustryInter_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            resources.ApplyResources(this.toolStripLabel, "toolStripLabel");
            // 
            // ResourceWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Temperate);
            this.Controls.Add(this.Storm);
            this.Controls.Add(this.Plasma);
            this.Controls.Add(this.Oceanic);
            this.Controls.Add(this.Lava);
            this.Controls.Add(this.Ice);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.Barren);
            this.Controls.Add(this.ResourcePanel);
            this.Controls.Add(this.NewIndustryInter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "ResourceWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.Temperate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plasma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oceanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barren)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button NewIndustryInter;
        private System.Windows.Forms.Panel ResourcePanel;
        private System.Windows.Forms.PictureBox Barren;
        private System.Windows.Forms.PictureBox Gas;
        private System.Windows.Forms.PictureBox Ice;
        private System.Windows.Forms.PictureBox Lava;
        private System.Windows.Forms.PictureBox Oceanic;
        private System.Windows.Forms.PictureBox Plasma;
        private System.Windows.Forms.PictureBox Storm;
        private System.Windows.Forms.PictureBox Temperate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel;
    }
}

