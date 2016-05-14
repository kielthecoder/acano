namespace AcanoTester
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
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(67, 52);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(150, 45);
            this.btnGetUsers.TabIndex = 0;
            this.btnGetUsers.Text = "Get Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(13, 13);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(52, 10);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(220, 20);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "https://172.31.189.189/api/v1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.btnGetUsers);
            this.Name = "Form1";
            this.Text = "Acano Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.TextBox txtHost;
    }
}

