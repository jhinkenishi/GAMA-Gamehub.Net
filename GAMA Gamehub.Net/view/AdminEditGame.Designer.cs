namespace GAMA_Gamehub.Net.view.controls
{
    partial class AdminEditGame
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
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.cboxGames = new System.Windows.Forms.ComboBox();
            this.pboxGameImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnPublish = new System.Windows.Forms.Button();
            this.gameImageFileDirectory = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.cboxGames);
            this.flowLayoutPanel1.Controls.Add(this.pboxGameImage);
            this.flowLayoutPanel1.Controls.Add(this.btnUpload);
            this.flowLayoutPanel1.Controls.Add(this.lblGameTitle);
            this.flowLayoutPanel1.Controls.Add(this.txtboxTitle);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtboxDesc);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cboxGenre);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxPublisher);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.numPrice);
            this.flowLayoutPanel1.Controls.Add(this.btnPublish);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 474);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.Location = new System.Drawing.Point(19, 32);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(319, 20);
            this.txtBoxSearch.TabIndex = 12;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // cboxGames
            // 
            this.cboxGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxGames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxGames.FormattingEnabled = true;
            this.cboxGames.Location = new System.Drawing.Point(19, 58);
            this.cboxGames.Name = "cboxGames";
            this.cboxGames.Size = new System.Drawing.Size(319, 21);
            this.cboxGames.TabIndex = 2;
            this.cboxGames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pboxGameImage
            // 
            this.pboxGameImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxGameImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxGameImage.ErrorImage = global::GAMA_Gamehub.Net.Properties.Resources.No_Image_Available;
            this.pboxGameImage.Location = new System.Drawing.Point(19, 85);
            this.pboxGameImage.Name = "pboxGameImage";
            this.pboxGameImage.Size = new System.Drawing.Size(319, 78);
            this.pboxGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxGameImage.TabIndex = 3;
            this.pboxGameImage.TabStop = false;
            this.pboxGameImage.Click += new System.EventHandler(this.pboxGameImage_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.AutoSize = true;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(19, 169);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpload.Size = new System.Drawing.Size(319, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameTitle.Location = new System.Drawing.Point(19, 195);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(319, 13);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Game Title";
            this.lblGameTitle.Click += new System.EventHandler(this.lblGameTitle_Click);
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxTitle.Location = new System.Drawing.Point(19, 211);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(319, 20);
            this.txtboxTitle.TabIndex = 1;
            this.txtboxTitle.TextChanged += new System.EventHandler(this.txtboxTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtboxDesc
            // 
            this.txtboxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxDesc.Location = new System.Drawing.Point(19, 250);
            this.txtboxDesc.Name = "txtboxDesc";
            this.txtboxDesc.Size = new System.Drawing.Size(319, 20);
            this.txtboxDesc.TabIndex = 5;
            this.txtboxDesc.TextChanged += new System.EventHandler(this.txtboxDesc_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboxGenre
            // 
            this.cboxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxGenre.FormattingEnabled = true;
            this.cboxGenre.Location = new System.Drawing.Point(19, 289);
            this.cboxGenre.Name = "cboxGenre";
            this.cboxGenre.Size = new System.Drawing.Size(319, 21);
            this.cboxGenre.TabIndex = 8;
            this.cboxGenre.SelectedIndexChanged += new System.EventHandler(this.cboxGenre_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(19, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Set Publisher";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPublisher.Location = new System.Drawing.Point(19, 329);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(319, 20);
            this.txtBoxPublisher.TabIndex = 10;
            this.txtBoxPublisher.TextChanged += new System.EventHandler(this.txtBoxPublisher_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(319, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPrice.AutoSize = true;
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(19, 368);
            this.numPrice.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(319, 20);
            this.numPrice.TabIndex = 15;
            // 
            // btnPublish
            // 
            this.btnPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublish.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPublish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPublish.Location = new System.Drawing.Point(19, 394);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(319, 23);
            this.btnPublish.TabIndex = 11;
            this.btnPublish.Text = "Done Edit";
            this.btnPublish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // gameImageFileDirectory
            // 
            this.gameImageFileDirectory.FileName = "UploadImage";
            this.gameImageFileDirectory.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            this.gameImageFileDirectory.FileOk += new System.ComponentModel.CancelEventHandler(this.FileOk);
            // 
            // AdminEditGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminEditGame";
            this.Size = new System.Drawing.Size(848, 477);
            this.Load += new System.EventHandler(this.AdminEditGame_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cboxGames;
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.PictureBox pboxGameImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDesc;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.OpenFileDialog gameImageFileDirectory;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPrice;
    }
}
