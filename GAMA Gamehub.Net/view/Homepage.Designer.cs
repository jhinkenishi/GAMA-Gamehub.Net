namespace GAMA_Gamehub.view.panel
{
    partial class Homepage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.scrollPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gameImageBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImageBox)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.scrollPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 589);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.flowLayoutPanel1.Controls.Add(this.btnCart);
            this.flowLayoutPanel1.Controls.Add(this.btnAccount);
            this.flowLayoutPanel1.Controls.Add(this.btnDev);
            this.flowLayoutPanel1.Controls.Add(this.btnAdmin);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(324, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.AutoSize = true;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(311, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(75, 25);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Login";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDev
            // 
            this.btnDev.AutoSize = true;
            this.btnDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDev.ForeColor = System.Drawing.Color.White;
            this.btnDev.Location = new System.Drawing.Point(230, 3);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(75, 25);
            this.btnDev.TabIndex = 1;
            this.btnDev.Text = "Developer";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AutoSize = true;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(149, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 25);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.searchbox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(315, 36);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(50, 3);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(250, 20);
            this.searchbox.TabIndex = 1;
            this.searchbox.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.listBoxGames);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 45);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(315, 563);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Available Games";
            // 
            // listBoxGames
            // 
            this.listBoxGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.listBoxGames.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel4.SetFlowBreak(this.listBoxGames, true);
            this.listBoxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGames.ForeColor = System.Drawing.Color.LightGray;
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 20;
            this.listBoxGames.Location = new System.Drawing.Point(3, 16);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(300, 250);
            this.listBoxGames.TabIndex = 0;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndex);
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.AutoSize = true;
            this.scrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.scrollPanel.Controls.Add(this.gameImageBox);
            this.scrollPanel.Controls.Add(this.lblTitle);
            this.scrollPanel.Controls.Add(this.lblPublisher);
            this.scrollPanel.Controls.Add(this.rchDescription);
            this.scrollPanel.Controls.Add(this.lblPrice);
            this.scrollPanel.Controls.Add(this.flowLayoutPanel5);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.scrollPanel.Location = new System.Drawing.Point(324, 45);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(470, 563);
            this.scrollPanel.TabIndex = 6;
            // 
            // gameImageBox
            // 
            this.gameImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.gameImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameImageBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.gameImageBox.ErrorImage = global::GAMA_Gamehub.Net.Properties.Resources.No_Image_Available;
            this.gameImageBox.Location = new System.Drawing.Point(3, 3);
            this.gameImageBox.Name = "gameImageBox";
            this.gameImageBox.Size = new System.Drawing.Size(460, 182);
            this.gameImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameImageBox.TabIndex = 0;
            this.gameImageBox.TabStop = false;
            this.gameImageBox.WaitOnLoad = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(3, 188);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(82, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(3, 225);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(83, 20);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Publisher";
            // 
            // rchDescription
            // 
            this.rchDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rchDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.rchDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchDescription.Location = new System.Drawing.Point(3, 248);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.ReadOnly = true;
            this.rchDescription.Size = new System.Drawing.Size(460, 69);
            this.rchDescription.TabIndex = 8;
            this.rchDescription.Text = "";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrice.Location = new System.Drawing.Point(3, 320);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 26);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.button1);
            this.flowLayoutPanel5.Controls.Add(this.button2);
            this.flowLayoutPanel5.Controls.Add(this.button3);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 349);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(460, 29);
            this.flowLayoutPanel5.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buy Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add To Cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Review";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            this.btnCart.AutoSize = true;
            this.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCart.FlatAppearance.BorderSize = 2;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Location = new System.Drawing.Point(392, 3);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(75, 25);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "Your Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Homepage";
            this.Size = new System.Drawing.Size(816, 589);
            this.Load += new System.EventHandler(this.load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImageBox)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel scrollPanel;
        private System.Windows.Forms.PictureBox gameImageBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.RichTextBox rchDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCart;
    }
}
