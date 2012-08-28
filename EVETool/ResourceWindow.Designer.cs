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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceWindow));
            this.ResourcePanel = new System.Windows.Forms.Panel();
            this.SetSize = new System.Windows.Forms.Panel();
            this.Temperate = new System.Windows.Forms.PictureBox();
            this.Storm = new System.Windows.Forms.PictureBox();
            this.Plasma = new System.Windows.Forms.PictureBox();
            this.Oceanic = new System.Windows.Forms.PictureBox();
            this.Lava = new System.Windows.Forms.PictureBox();
            this.Ice = new System.Windows.Forms.PictureBox();
            this.Gas = new System.Windows.Forms.PictureBox();
            this.Barren = new System.Windows.Forms.PictureBox();
            this.NewIndustryInter = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Temperate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plasma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oceanic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barren)).BeginInit();
            this.SuspendLayout();
            // 
            // ResourcePanel
            // 
            resources.ApplyResources(this.ResourcePanel, "ResourcePanel");
            this.ResourcePanel.Name = "ResourcePanel";
            // 
            // SetSize
            // 
            resources.ApplyResources(this.SetSize, "SetSize");
            this.SetSize.Name = "SetSize";
            // 
            // Temperate
            // 
            resources.ApplyResources(this.Temperate, "Temperate");
            this.Temperate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Temperate.Image = global::EVETool.Properties.Resources.Temperate;
            this.Temperate.Name = "Temperate";
            this.Temperate.TabStop = false;
            this.Temperate.Click += new System.EventHandler(this.Temperate_Click);
            this.Temperate.MouseHover += new System.EventHandler(this.Temperate_MouseHover);
            // 
            // Storm
            // 
            resources.ApplyResources(this.Storm, "Storm");
            this.Storm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Storm.Image = global::EVETool.Properties.Resources.Storm;
            this.Storm.Name = "Storm";
            this.Storm.TabStop = false;
            this.Storm.Click += new System.EventHandler(this.Storm_Click);
            this.Storm.MouseHover += new System.EventHandler(this.Storm_MouseHover);
            // 
            // Plasma
            // 
            resources.ApplyResources(this.Plasma, "Plasma");
            this.Plasma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Plasma.Image = global::EVETool.Properties.Resources.Plasma;
            this.Plasma.Name = "Plasma";
            this.Plasma.TabStop = false;
            this.Plasma.Click += new System.EventHandler(this.Plasma_Click);
            this.Plasma.MouseHover += new System.EventHandler(this.Plasma_MouseHover);
            // 
            // Oceanic
            // 
            resources.ApplyResources(this.Oceanic, "Oceanic");
            this.Oceanic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Oceanic.Image = global::EVETool.Properties.Resources.Oceanic;
            this.Oceanic.Name = "Oceanic";
            this.Oceanic.TabStop = false;
            this.Oceanic.Click += new System.EventHandler(this.Oceanic_Click);
            this.Oceanic.MouseHover += new System.EventHandler(this.Oceanic_MouseHover);
            // 
            // Lava
            // 
            resources.ApplyResources(this.Lava, "Lava");
            this.Lava.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lava.Image = global::EVETool.Properties.Resources.Lava;
            this.Lava.Name = "Lava";
            this.Lava.TabStop = false;
            this.Lava.Click += new System.EventHandler(this.Lava_Click);
            this.Lava.MouseHover += new System.EventHandler(this.Lava_MouseHover);
            // 
            // Ice
            // 
            resources.ApplyResources(this.Ice, "Ice");
            this.Ice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ice.Image = global::EVETool.Properties.Resources.Ice;
            this.Ice.Name = "Ice";
            this.Ice.TabStop = false;
            this.Ice.Click += new System.EventHandler(this.Ice_Click);
            this.Ice.MouseHover += new System.EventHandler(this.Ice_MouseHover);
            // 
            // Gas
            // 
            resources.ApplyResources(this.Gas, "Gas");
            this.Gas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Gas.Image = global::EVETool.Properties.Resources.Gas;
            this.Gas.Name = "Gas";
            this.Gas.TabStop = false;
            this.Gas.Click += new System.EventHandler(this.Gas_Click);
            this.Gas.MouseHover += new System.EventHandler(this.Gas_MouseHover);
            // 
            // Barren
            // 
            resources.ApplyResources(this.Barren, "Barren");
            this.Barren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Barren.Image = global::EVETool.Properties.Resources.Barren;
            this.Barren.Name = "Barren";
            this.Barren.TabStop = false;
            this.Barren.Click += new System.EventHandler(this.Barren_Click);
            this.Barren.MouseHover += new System.EventHandler(this.Barren_MouseHover);
            // 
            // NewIndustryInter
            // 
            this.NewIndustryInter.BackgroundImage = global::EVETool.Properties.Resources._33_128_2;
            resources.ApplyResources(this.NewIndustryInter, "NewIndustryInter");
            this.NewIndustryInter.Name = "NewIndustryInter";
            this.NewIndustryInter.UseVisualStyleBackColor = true;
            this.NewIndustryInter.Click += new System.EventHandler(this.NewIndustryInter_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToolTip.ForeColor = System.Drawing.SystemColors.Window;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.ReshowDelay = 100;
            // 
            // ResourceWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.Controls.Add(this.SetSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "ResourceWindow";
            ((System.ComponentModel.ISupportInitialize)(this.Temperate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plasma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Oceanic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button NewIndustryInter;
        private System.Windows.Forms.Panel ResourcePanel;
        private System.Windows.Forms.Panel SetSize;
        private System.Windows.Forms.PictureBox Barren;
        private System.Windows.Forms.PictureBox Gas;
        private System.Windows.Forms.PictureBox Ice;
        private System.Windows.Forms.PictureBox Lava;
        private System.Windows.Forms.PictureBox Oceanic;
        private System.Windows.Forms.PictureBox Plasma;
        private System.Windows.Forms.PictureBox Storm;
        private System.Windows.Forms.PictureBox Temperate;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

