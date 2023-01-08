namespace GAMA_Gamehub.Net.view.controls
{
    partial class AdminAddUser
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxConPassword = new System.Windows.Forms.TextBox();
            this.ckboxLoginStatus = new System.Windows.Forms.CheckBox();
            this.cbBoxUserType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lblName);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxEmail);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxUsername);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxPassword);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxConPassword);
            this.flowLayoutPanel1.Controls.Add(this.ckboxLoginStatus);
            this.flowLayoutPanel1.Controls.Add(this.cbBoxUserType);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(96, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 553);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 72;
            this.label1.Text = "Add User";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(19, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(162, 13);
            this.lblName.TabIndex = 61;
            this.lblName.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtBoxName.Location = new System.Drawing.Point(19, 69);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(162, 20);
            this.txtBoxName.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxEmail.Location = new System.Drawing.Point(19, 108);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(162, 20);
            this.txtBoxEmail.TabIndex = 64;
            this.txtBoxEmail.TextChanged += new System.EventHandler(this.OnEmailChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Username";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUsername.Location = new System.Drawing.Point(19, 147);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(162, 20);
            this.txtBoxUsername.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(19, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Password ";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPassword.Location = new System.Drawing.Point(19, 186);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(162, 20);
            this.txtBoxPassword.TabIndex = 68;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.OnPasswordChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Confirm Password";
            // 
            // txtBoxConPassword
            // 
            this.txtBoxConPassword.Location = new System.Drawing.Point(19, 225);
            this.txtBoxConPassword.Name = "txtBoxConPassword";
            this.txtBoxConPassword.PasswordChar = '*';
            this.txtBoxConPassword.Size = new System.Drawing.Size(162, 20);
            this.txtBoxConPassword.TabIndex = 73;
            // 
            // ckboxLoginStatus
            // 
            this.ckboxLoginStatus.AutoSize = true;
            this.ckboxLoginStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxLoginStatus.Location = new System.Drawing.Point(19, 251);
            this.ckboxLoginStatus.Name = "ckboxLoginStatus";
            this.ckboxLoginStatus.Size = new System.Drawing.Size(162, 17);
            this.ckboxLoginStatus.TabIndex = 69;
            this.ckboxLoginStatus.Text = "Login Status";
            this.ckboxLoginStatus.UseVisualStyleBackColor = true;
            // 
            // cbBoxUserType
            // 
            this.cbBoxUserType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxUserType.FormattingEnabled = true;
            this.cbBoxUserType.Location = new System.Drawing.Point(19, 274);
            this.cbBoxUserType.Name = "cbBoxUserType";
            this.cbBoxUserType.Size = new System.Drawing.Size(162, 21);
            this.cbBoxUserType.TabIndex = 70;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Location = new System.Drawing.Point(19, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(162, 23);
            this.btnSubmit.TabIndex = 71;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AdminAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminAddUser";
            this.Size = new System.Drawing.Size(781, 556);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.CheckBox ckboxLoginStatus;
        private System.Windows.Forms.ComboBox cbBoxUserType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxConPassword;
    }
}
