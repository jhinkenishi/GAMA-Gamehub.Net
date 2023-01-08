namespace GAMA_Gamehub.Net.view.controls
{
    partial class DeveloperPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gamePic = new System.Windows.Forms.PictureBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtboxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.inptPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxGamesPublished = new System.Windows.Forms.ListBox();
            this.fileManager = new System.Windows.Forms.OpenFileDialog();
            this.gameImagesLIst = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptPrice)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.gamePic);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadFile);
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxTitle);
            this.flowLayoutPanel1.Controls.Add(this.lblDesc);
            this.flowLayoutPanel1.Controls.Add(this.txtboxDesc);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cbGenres);
            this.flowLayoutPanel1.Controls.Add(this.lblPrice);
            this.flowLayoutPanel1.Controls.Add(this.inptPrice);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtBoxPublisher);
            this.flowLayoutPanel1.Controls.Add(this.btnPublish);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(385, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 421);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // gamePic
            // 
            this.gamePic.BackColor = System.Drawing.Color.LightGray;
            this.gamePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePic.Location = new System.Drawing.Point(3, 3);
            this.gamePic.Name = "gamePic";
            this.gamePic.Size = new System.Drawing.Size(374, 133);
            this.gamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePic.TabIndex = 2;
            this.gamePic.TabStop = false;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.AutoSize = true;
            this.btnUploadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadFile.Location = new System.Drawing.Point(3, 142);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(374, 23);
            this.btnUploadFile.TabIndex = 6;
            this.btnUploadFile.Text = "Upload Image";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 168);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Game Title";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTitle.Location = new System.Drawing.Point(3, 184);
            this.txtBoxTitle.Multiline = true;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(374, 20);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 207);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 13);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Game Description";
            // 
            // txtboxDesc
            // 
            this.txtboxDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxDesc.Location = new System.Drawing.Point(3, 223);
            this.txtboxDesc.Multiline = true;
            this.txtboxDesc.Name = "txtboxDesc";
            this.txtboxDesc.Size = new System.Drawing.Size(374, 20);
            this.txtboxDesc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Genre";
            // 
            // cbGenres
            // 
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(3, 262);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(374, 21);
            this.cbGenres.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 286);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Set Price";
            // 
            // inptPrice
            // 
            this.inptPrice.DecimalPlaces = 2;
            this.inptPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inptPrice.Location = new System.Drawing.Point(3, 302);
            this.inptPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.inptPrice.Name = "inptPrice";
            this.inptPrice.Size = new System.Drawing.Size(374, 20);
            this.inptPrice.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Your Publisher";
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(3, 341);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(374, 20);
            this.txtBoxPublisher.TabIndex = 12;
            // 
            // btnPublish
            // 
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPublish.Location = new System.Drawing.Point(3, 367);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(374, 23);
            this.btnPublish.TabIndex = 5;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.lstBoxGamesPublished);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(376, 421);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You published Games";
            // 
            // lstBoxGamesPublished
            // 
            this.lstBoxGamesPublished.BackColor = System.Drawing.Color.White;
            this.lstBoxGamesPublished.FormattingEnabled = true;
            this.lstBoxGamesPublished.Location = new System.Drawing.Point(3, 23);
            this.lstBoxGamesPublished.Name = "lstBoxGamesPublished";
            this.lstBoxGamesPublished.Size = new System.Drawing.Size(364, 368);
            this.lstBoxGamesPublished.TabIndex = 1;
            this.lstBoxGamesPublished.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDonw);
            // 
            // fileManager
            // 
            this.fileManager.FileName = "Upload Image";
            this.fileManager.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            this.fileManager.FileOk += new System.ComponentModel.CancelEventHandler(this.OnFileOk);
            // 
            // gameImagesLIst
            // 
            this.gameImagesLIst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("gameImagesLIst.ImageStream")));
            this.gameImagesLIst.TransparentColor = System.Drawing.Color.Transparent;
            this.gameImagesLIst.Images.SetKeyName(0, "image.jpg");
            this.gameImagesLIst.Images.SetKeyName(1, "Flow Chart Game Distribution.png");
            this.gameImagesLIst.Images.SetKeyName(2, "GAMA GAMEHUB Use Case-1.png");
            this.gameImagesLIst.Images.SetKeyName(3, "GAMA GAMEHUB-1.png");
            // 
            // DeveloperPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeveloperPage";
            this.Size = new System.Drawing.Size(765, 462);
            this.Load += new System.EventHandler(this.Loader);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptPrice)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox gamePic;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtboxDesc;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.OpenFileDialog fileManager;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown inptPrice;
        private System.Windows.Forms.ImageList gameImagesLIst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxGamesPublished;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPublisher;
    }
}
