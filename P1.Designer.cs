namespace EVETool
{
    partial class P1
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
            this.RMAmount = new System.Windows.Forms.TextBox();
            this.RMLabel = new System.Windows.Forms.TextBox();
            this.ResultAmount = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RMAmount
            // 
            this.RMAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMAmount.Location = new System.Drawing.Point(371, 157);
            this.RMAmount.Name = "RMAmount";
            this.RMAmount.ReadOnly = true;
            this.RMAmount.Size = new System.Drawing.Size(100, 23);
            this.RMAmount.TabIndex = 29;
            this.RMAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RMLabel
            // 
            this.RMLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RMLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.RMLabel.Location = new System.Drawing.Point(355, 128);
            this.RMLabel.Name = "RMLabel";
            this.RMLabel.ReadOnly = true;
            this.RMLabel.Size = new System.Drawing.Size(132, 23);
            this.RMLabel.TabIndex = 28;
            this.RMLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RMLabel.WordWrap = false;
            // 
            // ResultAmount
            // 
            this.ResultAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultAmount.Location = new System.Drawing.Point(371, 77);
            this.ResultAmount.Name = "ResultAmount";
            this.ResultAmount.ReadOnly = true;
            this.ResultAmount.Size = new System.Drawing.Size(100, 23);
            this.ResultAmount.TabIndex = 31;
            this.ResultAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.SystemColors.Window;
            this.Result.Location = new System.Drawing.Point(355, 48);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(132, 23);
            this.Result.TabIndex = 30;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Result.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "P1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(286, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 64);
            this.panel3.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "P0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(286, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 64);
            this.panel1.TabIndex = 43;
            // 
            // P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ResultAmount);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.RMAmount);
            this.Controls.Add(this.RMLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "P1";
            this.Size = new System.Drawing.Size(850, 233);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RMAmount;
        private System.Windows.Forms.TextBox RMLabel;
        private System.Windows.Forms.TextBox ResultAmount;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
