namespace EVETool
{
    partial class ResourcePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourcePanel));
            this.ResourceTier = new System.Windows.Forms.ComboBox();
            this.TierLabel = new System.Windows.Forms.Label();
            this.DesiredProduct = new System.Windows.Forms.ComboBox();
            this.DesiredLabel = new System.Windows.Forms.Label();
            this.ResultsPanel = new System.Windows.Forms.Panel();
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
            resources.ApplyResources(this.ResourceTier, "ResourceTier");
            this.ResourceTier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ResourceTier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ResourceTier.Name = "ResourceTier";
            this.ResourceTier.SelectedIndexChanged += new System.EventHandler(this.ResourceTier_SelectedIndexChanged);
            this.ResourceTier.MouseEnter += new System.EventHandler(this.ResourceTier_MouseEnter);
            // 
            // TierLabel
            // 
            resources.ApplyResources(this.TierLabel, "TierLabel");
            this.TierLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TierLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TierLabel.Name = "TierLabel";
            this.TierLabel.UseMnemonic = false;
            // 
            // DesiredProduct
            // 
            resources.ApplyResources(this.DesiredProduct, "DesiredProduct");
            this.DesiredProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DesiredProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DesiredProduct.FormattingEnabled = true;
            this.DesiredProduct.Name = "DesiredProduct";
            this.DesiredProduct.SelectedIndexChanged += new System.EventHandler(this.DesiredProduct_SelectedIndexChanged);
            // 
            // DesiredLabel
            // 
            resources.ApplyResources(this.DesiredLabel, "DesiredLabel");
            this.DesiredLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DesiredLabel.Name = "DesiredLabel";
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            resources.ApplyResources(this.ResultsPanel, "ResultsPanel");
            this.ResultsPanel.Name = "ResultsPanel";
            // 
            // CalculateUsing
            // 
            resources.ApplyResources(this.CalculateUsing, "CalculateUsing");
            this.CalculateUsing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CalculateUsing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CalculateUsing.FormattingEnabled = true;
            this.CalculateUsing.Items.AddRange(new object[] {
            resources.GetString("CalculateUsing.Items"),
            resources.GetString("CalculateUsing.Items1")});
            this.CalculateUsing.Name = "CalculateUsing";
            this.CalculateUsing.SelectedIndexChanged += new System.EventHandler(this.CalculateUsing_SelectedIndexChanged);
            // 
            // CalculateUsingLabel
            // 
            resources.ApplyResources(this.CalculateUsingLabel, "CalculateUsingLabel");
            this.CalculateUsingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalculateUsingLabel.Name = "CalculateUsingLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // Value
            // 
            resources.ApplyResources(this.Value, "Value");
            this.Value.Name = "Value";
            // 
            // MassLabel
            // 
            resources.ApplyResources(this.MassLabel, "MassLabel");
            this.MassLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MassLabel.Name = "MassLabel";
            // 
            // QuantityUnits
            // 
            resources.ApplyResources(this.QuantityUnits, "QuantityUnits");
            this.QuantityUnits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuantityUnits.Name = "QuantityUnits";
            // 
            // BuildResult
            // 
            this.BuildResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BuildResult.BackgroundImage = global::EVETool.Properties.Resources._23_64_2;
            resources.ApplyResources(this.BuildResult, "BuildResult");
            this.BuildResult.Name = "BuildResult";
            this.BuildResult.UseVisualStyleBackColor = false;
            this.BuildResult.Click += new System.EventHandler(this.BuildResult_Click_1);
            // 
            // ResourcePanel
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.QuantityUnits);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateUsingLabel);
            this.Controls.Add(this.CalculateUsing);
            this.Controls.Add(this.BuildResult);
            this.Controls.Add(this.DesiredLabel);
            this.Controls.Add(this.DesiredProduct);
            this.Controls.Add(this.TierLabel);
            this.Controls.Add(this.ResourceTier);
            this.Controls.Add(this.ResultsPanel);
            this.Name = "ResourcePanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ResourceTier;
        private System.Windows.Forms.Label TierLabel;
        private System.Windows.Forms.ComboBox DesiredProduct;
        private System.Windows.Forms.Label DesiredLabel;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Button BuildResult;
        private System.Windows.Forms.ComboBox CalculateUsing;
        private System.Windows.Forms.Label CalculateUsingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label QuantityUnits;
    }
}
