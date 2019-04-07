using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDLinqTp2019
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }
        private DataGridView dataGridViewBooks1;
       

        public AddBookForm(DataGridView dataGridView1)
        {
            this.dataGridViewBooks1 = dataGridView1;
            InitializeComponent();
        }

        private void bt_AddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm fa = new AddAuthorForm();
            fa.Show();
        }

        private void bt_AddBook_Click(object sender, EventArgs e)
        {
            //Create a Book object
            Book b1 = new Book();
            //Initialize Properties
            b1.IsbnCode = txt_IsbnCode.Text;
            b1.Title = txt_Title.Text;
            b1.NbrPages = int.Parse(txt_NbrPages.Text);

            //Add b1 to Books then to the Database
            ListOfBooksForm.DbDataContext.Books.InsertOnSubmit(b1);
            ListOfBooksForm.DbDataContext.SubmitChanges();
            MessageBox.Show("The book has been added successfully");

            //update the content Of the dataGridView of Books
            dataGridViewBooks1.DataSource = null;
            dataGridViewBooks1.DataSource = ListOfBooksForm.DbDataContext.Books;
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
