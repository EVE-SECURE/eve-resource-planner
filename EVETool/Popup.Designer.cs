namespace EVETool
{
    partial class Popup
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
            this.Okay = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Okay
            // 
            this.Okay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Okay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Okay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Okay.Location = new System.Drawing.Point(354, 87);
            this.Okay.Name = "Okay";
            this.Okay.Size = new System.Drawing.Size(75, 23);
            this.Okay.TabIndex = 0;
            this.Okay.Text = "OK";
            this.Okay.UseVisualStyleBackColor = false;
            this.Okay.Click += new System.EventHandler(this.Okay_Click);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Message.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Message.Location = new System.Drawing.Point(12, 30);
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(759, 16);
            this.Message.TabIndex = 1;
            this.Message.Text = "Error";
            this.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Popup
            // 
            this.AcceptButton = this.Okay;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(783, 131);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Okay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Popup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Okay;
        private System.Windows.Forms.TextBox Message;
    }
}