namespace CRUDLinqTp2019
{
    partial class AddAuthorForm
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
            this.dtp_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.BirthDay = new System.Windows.Forms.Label();
            this.bt_Close = new System.Windows.Forms.Button();
            this.bt_AddAuthor = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Nationality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Id = new System.Windows.Forms.ComboBox();
            this.chk_ExistingAuthor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dtp_BirthDay
            // 
            this.dtp_BirthDay.Location = new System.Drawing.Point(257, 242);
            this.dtp_BirthDay.Name = "dtp_BirthDay";
            this.dtp_BirthDay.Size = new System.Drawing.Size(203, 20);
            this.dtp_BirthDay.TabIndex = 38;
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay.Location = new System.Drawing.Point(58, 244);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(72, 18);
            this.BirthDay.TabIndex = 37;
            this.BirthDay.Text = "BirthDay";
            // 
            // bt_Close
            // 
            this.bt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Close.Location = new System.Drawing.Point(432, 318);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(130, 42);
            this.bt_Close.TabIndex = 36;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // bt_AddAuthor
            // 
            this.bt_AddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddAuthor.Location = new System.Drawing.Point(216, 318);
            this.bt_AddAuthor.Name = "bt_AddAuthor";
            this.bt_AddAuthor.Size = new System.Drawing.Size(130, 42);
            this.bt_AddAuthor.TabIndex = 35;
            this.bt_AddAuthor.Text = "Add Author";
            this.bt_AddAuthor.UseVisualStyleBackColor = true;
            this.bt_AddAuthor.Click += new System.EventHandler(this.bt_AddAuthor_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(257, 156);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(203, 24);
            this.txt_Name.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID";
            // 
            // cmb_Nationality
            // 
            this.cmb_Nationality.FormattingEnabled = true;
            this.cmb_Nationality.Items.AddRange(new object[] {
            "Tunisian",
            "Britsh",
            "Amarican",
            "Algerian"});
            this.cmb_Nationality.Location = new System.Drawing.Point(257, 203);
            this.cmb_Nationality.Name = "cmb_Nationality";
            this.cmb_Nationality.Size = new System.Drawing.Size(203, 21);
            this.cmb_Nationality.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(121, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "Enter Author Informations";
            // 
            // cmb_Id
            // 
            this.cmb_Id.FormattingEnabled = true;
            this.cmb_Id.Items.AddRange(new object[] {
            "Tunisian",
            "Britsh",
            "Amarican",
            "Algerian"});
            this.cmb_Id.Location = new System.Drawing.Point(257, 119);
            this.cmb_Id.Name = "cmb_Id";
            this.cmb_Id.Size = new System.Drawing.Size(203, 21);
            this.cmb_Id.TabIndex = 43;
            this.cmb_Id.SelectedIndexChanged += new System.EventHandler(this.cmb_Id_SelectedIndexChanged);
            // 
            // chk_ExistingAuthor
            // 
            this.chk_ExistingAuthor.AutoSize = true;
            this.chk_ExistingAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chk_ExistingAuthor.Location = new System.Drawing.Point(497, 119);
            this.chk_ExistingAuthor.Name = "chk_ExistingAuthor";
            this.chk_ExistingAuthor.Size = new System.Drawing.Size(140, 22);
            this.chk_ExistingAuthor.TabIndex = 44;
            this.chk_ExistingAuthor.Text = "Existing Author";
            this.chk_ExistingAuthor.UseVisualStyleBackColor = true;
            this.chk_ExistingAuthor.CheckedChanged += new System.EventHandler(this.chk_ExistingAuthor_CheckedChanged);
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.chk_ExistingAuthor);
            this.Controls.Add(this.cmb_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Nationality);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_BirthDay);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_AddAuthor);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AddAuthorForm";
            this.Text = "AddAuthorForm";
            this.Load += new System.EventHandler(this.AddAuthorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_BirthDay;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.Button bt_Close;
        private System.Windows.Forms.Button bt_AddAuthor;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Nationality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Id;
        private System.Windows.Forms.CheckBox chk_ExistingAuthor;
    }
}