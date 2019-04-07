namespace CRUDLinqTp2019
{
    partial class ListOfBooksForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_FilterValue = new System.Windows.Forms.TextBox();
            this.cmb_OrderBy = new System.Windows.Forms.ComboBox();
            this.cmb_filterBy = new System.Windows.Forms.ComboBox();
            this.bt_ModifyBook = new System.Windows.Forms.Button();
            this.bt_AddBook = new System.Windows.Forms.Button();
            this.bt_DeleteBook = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(41, 165);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(510, 246);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_FilterValue);
            this.groupBox1.Controls.Add(this.cmb_OrderBy);
            this.groupBox1.Controls.Add(this.cmb_filterBy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Value";
            // 
            // txt_FilterValue
            // 
            this.txt_FilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilterValue.Location = new System.Drawing.Point(393, 19);
            this.txt_FilterValue.Name = "txt_FilterValue";
            this.txt_FilterValue.Size = new System.Drawing.Size(141, 24);
            this.txt_FilterValue.TabIndex = 8;
            // 
            // cmb_OrderBy
            // 
            this.cmb_OrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OrderBy.FormattingEnabled = true;
            this.cmb_OrderBy.Items.AddRange(new object[] {
            "Title",
            "Nomber of pages",
            "Release Date",
            "Author Name"});
            this.cmb_OrderBy.Location = new System.Drawing.Point(242, 55);
            this.cmb_OrderBy.Name = "cmb_OrderBy";
            this.cmb_OrderBy.Size = new System.Drawing.Size(162, 26);
            this.cmb_OrderBy.TabIndex = 5;
            // 
            // cmb_filterBy
            // 
            this.cmb_filterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_filterBy.FormattingEnabled = true;
            this.cmb_filterBy.Items.AddRange(new object[] {
            "Title",
            "Release Date",
            "Number of Pages",
            "Author Name"});
            this.cmb_filterBy.Location = new System.Drawing.Point(81, 19);
            this.cmb_filterBy.Name = "cmb_filterBy";
            this.cmb_filterBy.Size = new System.Drawing.Size(162, 26);
            this.cmb_filterBy.TabIndex = 4;
            // 
            // bt_ModifyBook
            // 
            this.bt_ModifyBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ModifyBook.Location = new System.Drawing.Point(670, 133);
            this.bt_ModifyBook.Name = "bt_ModifyBook";
            this.bt_ModifyBook.Size = new System.Drawing.Size(116, 34);
            this.bt_ModifyBook.TabIndex = 0;
            this.bt_ModifyBook.Text = "Modify Book";
            this.bt_ModifyBook.UseVisualStyleBackColor = true;
            this.bt_ModifyBook.Click += new System.EventHandler(this.bt_ModifyBook_Click);
            // 
            // bt_AddBook
            // 
            this.bt_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddBook.Location = new System.Drawing.Point(670, 75);
            this.bt_AddBook.Name = "bt_AddBook";
            this.bt_AddBook.Size = new System.Drawing.Size(116, 34);
            this.bt_AddBook.TabIndex = 1;
            this.bt_AddBook.Text = "Add Book";
            this.bt_AddBook.UseVisualStyleBackColor = true;
            this.bt_AddBook.Click += new System.EventHandler(this.bt_AddBook_Click);
            // 
            // bt_DeleteBook
            // 
            this.bt_DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeleteBook.Location = new System.Drawing.Point(670, 190);
            this.bt_DeleteBook.Name = "bt_DeleteBook";
            this.bt_DeleteBook.Size = new System.Drawing.Size(116, 34);
            this.bt_DeleteBook.TabIndex = 2;
            this.bt_DeleteBook.Text = "Delete Book";
            this.bt_DeleteBook.UseVisualStyleBackColor = true;
            this.bt_DeleteBook.Click += new System.EventHandler(this.bt_DeleteBook_Click);
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(670, 249);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(116, 34);
            this.bt_Close.TabIndex = 3;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(354, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Of Books";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListOfBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_AddBook);
            this.Controls.Add(this.bt_DeleteBook);
            this.Controls.Add(this.bt_ModifyBook);
            this.Name = "ListOfBooksForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.ListOfBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_FilterValue;
        private System.Windows.Forms.ComboBox cmb_OrderBy;
        private System.Windows.Forms.ComboBox cmb_filterBy;
        private System.Windows.Forms.Button bt_ModifyBook;
        private System.Windows.Forms.Button bt_AddBook;
        private System.Windows.Forms.Button bt_DeleteBook;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

