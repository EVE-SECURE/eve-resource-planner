namespace EVETool
{
    partial class Resources
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
            this.ResourceTier = new System.Windows.Forms.ComboBox();
            this.TierLabel = new System.Windows.Forms.Label();
            this.DesiredProduct = new System.Windows.Forms.ComboBox();
            this.DesiredLabel = new System.Windows.Forms.Label();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.Spacer = new System.Windows.Forms.Panel();
            this.CalculateUsing = new System.Windows.Forms.ComboBox();
            this.CalculateUsingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.MassLabel = new System.Windows.Forms.Label();
            this.QuantityUnits = new System.Windows.Forms.Label();
            this.BuildResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResourceTier
            // 
            this.ResourceTier.FormattingEnabled = true;
            this.ResourceTier.Location = new System.Drawing.Point(143, 24);
            this.ResourceTier.Name = "ResourceTier";
            this.ResourceTier.Size = new System.Drawing.Size(159, 21);
            this.ResourceTier.TabIndex = 0;
            this.ResourceTier.SelectedIndexChanged += new System.EventHandler(this.ResourceTier_SelectedIndexChanged);
            // 
            // TierLabel
            // 
            this.TierLabel.AutoSize = true;
            this.TierLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TierLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TierLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TierLabel.Location = new System.Drawing.Point(23, 27);
            this.TierLabel.Name = "TierLabel";
            this.TierLabel.Size = new System.Drawing.Size(76, 15);
            this.TierLabel.TabIndex = 1;
            this.TierLabel.Text = "Product Tier";
            this.TierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DesiredProduct
            // 
            this.DesiredProduct.FormattingEnabled = true;
            this.DesiredProduct.Location = new System.Drawing.Point(143, 52);
            this.DesiredProduct.Name = "DesiredProduct";
            this.DesiredProduct.Size = new System.Drawing.Size(159, 21);
            this.DesiredProduct.TabIndex = 2;
            this.DesiredProduct.Visible = false;
            this.DesiredProduct.SelectedIndexChanged += new System.EventHandler(this.DesiredProduct_SelectedIndexChanged);
            // 
            // DesiredLabel
            // 
            this.DesiredLabel.AutoSize = true;
            this.DesiredLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DesiredLabel.Location = new System.Drawing.Point(23, 55);
            this.DesiredLabel.Name = "DesiredLabel";
            this.DesiredLabel.Size = new System.Drawing.Size(97, 15);
            this.DesiredLabel.TabIndex = 3;
            this.DesiredLabel.Text = "Desired Product";
            this.DesiredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DesiredLabel.Visible = false;
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.AutoScroll = true;
            this.ResultsPanel.Location = new System.Drawing.Point(2, 106);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(850, 233);
            this.ResultsPanel.TabIndex = 7;
            // 
            // Spacer
            // 
            this.Spacer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Spacer.Location = new System.Drawing.Point(2, 101);
            this.Spacer.Name = "Spacer";
            this.Spacer.Size = new System.Drawing.Size(850, 6);
            this.Spacer.TabIndex = 8;
            // 
            // CalculateUsing
            // 
            this.CalculateUsing.FormattingEnabled = true;
            this.CalculateUsing.Items.AddRange(new object[] {
            "Quantity",
            "Maximum Mass"});
            this.CalculateUsing.Location = new System.Drawing.Point(405, 40);
            this.CalculateUsing.Name = "CalculateUsing";
            this.CalculateUsing.Size = new System.Drawing.Size(121, 21);
            this.CalculateUsing.TabIndex = 12;
            this.CalculateUsing.Visible = false;
            this.CalculateUsing.SelectedIndexChanged += new System.EventHandler(this.CalculateUsing_SelectedIndexChanged);
            // 
            // CalculateUsingLabel
            // 
            this.CalculateUsingLabel.AutoSize = true;
            this.CalculateUsingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateUsingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalculateUsingLabel.Location = new System.Drawing.Point(308, 43);
            this.CalculateUsingLabel.Name = "CalculateUsingLabel";
            this.CalculateUsingLabel.Size = new System.Drawing.Size(91, 15);
            this.CalculateUsingLabel.TabIndex = 13;
            this.CalculateUsingLabel.Text = "Calculate Using";
            this.CalculateUsingLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(533, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Of";
            this.label1.Visible = false;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(561, 40);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(110, 20);
            this.Value.TabIndex = 15;
            this.Value.Visible = false;
            this.Value.WordWrap = false;
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MassLabel.Location = new System.Drawing.Point(678, 44);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(23, 15);
            this.MassLabel.TabIndex = 16;
            this.MassLabel.Text = "m³";
            this.MassLabel.Visible = false;
            // 
            // QuantityUnits
            // 
            this.QuantityUnits.AutoSize = true;
            this.QuantityUnits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityUnits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuantityUnits.Location = new System.Drawing.Point(678, 43);
            this.QuantityUnits.Name = "QuantityUnits";
            this.QuantityUnits.Size = new System.Drawing.Size(14, 15);
            this.QuantityUnits.TabIndex = 17;
            this.QuantityUnits.Text = "u";
            this.QuantityUnits.Visible = false;
            // 
            // BuildResult
            // 
            this.BuildResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BuildResult.BackgroundImage = global::EVETool.Properties.Resources._23_64_2;
            this.BuildResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuildResult.Location = new System.Drawing.Point(766, 19);
            this.BuildResult.Name = "BuildResult";
            this.BuildResult.Size = new System.Drawing.Size(64, 64);
            this.BuildResult.TabIndex = 9;
            this.BuildResult.UseVisualStyleBackColor = false;
            this.BuildResult.Click += new System.EventHandler(this.BuildResult_Click_1);
            // 
            // Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.QuantityUnits);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateUsingLabel);
            this.Controls.Add(this.CalculateUsing);
            this.Controls.Add(this.BuildResult);
            this.Controls.Add(this.Spacer);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.DesiredLabel);
            this.Controls.Add(this.DesiredProduct);
            this.Controls.Add(this.TierLabel);
            this.Controls.Add(this.ResourceTier);
            this.Name = "Resources";
            this.Size = new System.Drawing.Size(854, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ResourceTier;
        private System.Windows.Forms.Label TierLabel;
        private System.Windows.Forms.ComboBox DesiredProduct;
        private System.Windows.Forms.Label DesiredLabel;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Panel Spacer;
        private System.Windows.Forms.Button BuildResult;
        private System.Windows.Forms.ComboBox CalculateUsing;
        private System.Windows.Forms.Label CalculateUsingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label QuantityUnits;
    }
}
