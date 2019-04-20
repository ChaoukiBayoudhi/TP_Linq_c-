namespace CRUDLinqTp2019
{
    partial class ModifyBookForm
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
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_ModifyBook = new System.Windows.Forms.Button();
            this.bt_ModifyAuthor = new System.Windows.Forms.Button();
            this.txt_NbrPages = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_AddImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.cmb_isbnCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(562, 396);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(130, 30);
            this.bt_Close.TabIndex = 25;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_ModifyBook
            // 
            this.bt_ModifyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ModifyBook.Location = new System.Drawing.Point(346, 396);
            this.bt_ModifyBook.Name = "bt_ModifyBook";
            this.bt_ModifyBook.Size = new System.Drawing.Size(130, 30);
            this.bt_ModifyBook.TabIndex = 24;
            this.bt_ModifyBook.Text = "Modify Book";
            this.bt_ModifyBook.UseVisualStyleBackColor = true;
            this.bt_ModifyBook.Click += new System.EventHandler(this.bt_ModifyBook_Click);
            // 
            // bt_ModifyAuthor
            // 
            this.bt_ModifyAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ModifyAuthor.Location = new System.Drawing.Point(319, 238);
            this.bt_ModifyAuthor.Name = "bt_ModifyAuthor";
            this.bt_ModifyAuthor.Size = new System.Drawing.Size(141, 30);
            this.bt_ModifyAuthor.TabIndex = 23;
            this.bt_ModifyAuthor.Text = "Modify Author";
            this.bt_ModifyAuthor.UseVisualStyleBackColor = true;
            // 
            // txt_NbrPages
            // 
            this.txt_NbrPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NbrPages.Location = new System.Drawing.Point(294, 157);
            this.txt_NbrPages.Name = "txt_NbrPages";
            this.txt_NbrPages.Size = new System.Drawing.Size(166, 24);
            this.txt_NbrPages.TabIndex = 22;
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(294, 113);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(166, 24);
            this.txt_Title.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "List Of Authors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number Of Pages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "ISBN Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(265, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modify Book Informations";
            // 
            // bt_AddImage
            // 
            this.bt_AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddImage.Location = new System.Drawing.Point(38, 139);
            this.bt_AddImage.Name = "bt_AddImage";
            this.bt_AddImage.Size = new System.Drawing.Size(130, 30);
            this.bt_AddImage.TabIndex = 11;
            this.bt_AddImage.Text = "Browse";
            this.bt_AddImage.UseVisualStyleBackColor = true;
            this.bt_AddImage.Click += new System.EventHandler(this.bt_AddImage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.bt_AddImage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(509, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 183);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cover Image";
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(64, 285);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.Size = new System.Drawing.Size(396, 96);
            this.dataGridViewAuthors.TabIndex = 26;
            // 
            // cmb_isbnCode
            // 
            this.cmb_isbnCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_isbnCode.FormattingEnabled = true;
            this.cmb_isbnCode.Location = new System.Drawing.Point(294, 72);
            this.cmb_isbnCode.Name = "cmb_isbnCode";
            this.cmb_isbnCode.Size = new System.Drawing.Size(166, 21);
            this.cmb_isbnCode.TabIndex = 28;
            this.cmb_isbnCode.SelectedIndexChanged += new System.EventHandler(this.cmb_isbnCode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Release Date";
            // 
            // dtp_ReleaseDate
            // 
            this.dtp_ReleaseDate.Location = new System.Drawing.Point(294, 196);
            this.dtp_ReleaseDate.Name = "dtp_ReleaseDate";
            this.dtp_ReleaseDate.Size = new System.Drawing.Size(166, 20);
            this.dtp_ReleaseDate.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUDLinqTp2019.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(14, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 113);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ModifyBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_ReleaseDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_isbnCode);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_ModifyBook);
            this.Controls.Add(this.bt_ModifyAuthor);
            this.Controls.Add(this.txt_NbrPages);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewAuthors);
            this.Name = "ModifyBookForm";
            this.Text = "ModifyBookForm";
            this.Load += new System.EventHandler(this.ModifyBookForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_ModifyBook;
        private System.Windows.Forms.Button bt_ModifyAuthor;
        private System.Windows.Forms.TextBox txt_NbrPages;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_AddImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.ComboBox cmb_isbnCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_ReleaseDate;
    }
}