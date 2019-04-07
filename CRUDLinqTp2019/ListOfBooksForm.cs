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
    public partial class ListOfBooksForm : Form
    {
        internal static LibraryLinqDataContext DbDataContext = new LibraryLinqDataContext();
        public ListOfBooksForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //// Determine if text has changed in the textbox by comparing to original text.
            //if (textBox1.Text != strMyOriginalText)
            //{
            // Display a MsgBox asking the user to save changes or abort.
            //if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
            //   MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // Cancel the Closing event from closing the form.
            //    e.Cancel = false;
            //    // Call method to save file...
            //}
            //else
            //    e.Cancel = true;
            //}
            // or this code
            const string message = "Are you sure that you would like to cancel the installer?";
            const string caption = "Cancel Installer";

            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNoCancel,
                             MessageBoxIcon.Question,
                             MessageBoxDefaultButton.Button2);

            e.Cancel = (result == DialogResult.No);
        }

        private void bt_AddBook_Click(object sender, EventArgs e)
        {
            AddBookForm fb = new AddBookForm(dataGridViewBooks);
            fb.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListOfBooksForm_Load(object sender, EventArgs e)
        {
           // dataGridViewBooks.DataSource = DbDataContext.Books;
            //or by using from selct
            dataGridViewBooks.DataSource = (from b1 in DbDataContext.Books
                                            select b1).ToList<Book>();

            cmb_filterBy.SelectedIndex = 0;
            cmb_OrderBy.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = null;
           dataGridViewBooks.DataSource = from b1 in DbDataContext.Books
                                          select b1;
        }

        private void bt_DeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                //index of the selected row
                int index = dataGridViewBooks.CurrentCell.RowIndex;
                string IsbnCode = dataGridViewBooks[0, index].Value.ToString();
                Book b1 = DbDataContext.Books.Single<Book>(x => x.IsbnCode == IsbnCode);

                DbDataContext.Books.DeleteOnSubmit(b1);
                DbDataContext.SubmitChanges();
                MessageBox.Show("The book has been deleted");
                dataGridViewBooks.DataSource = null;
                dataGridViewBooks.DataSource = from y in DbDataContext.Books
                                               select y;
                                            // or=DbDataContext.Books;
            }
            catch (Exception)
            {

                MessageBox.Show("Please select a row in the dataGridView");
            }
            
        }

        private void bt_ModifyBook_Click(object sender, EventArgs e)
        {

        }
    }
}
