using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDLinqTp2019
{
    public partial class ListOfBooksForm : Form
    {
        internal static LibraryLinqDataContext DbDataContext = new LibraryLinqDataContext();



        //Connected Mode
        private SqlConnection conx = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False");
        private SqlCommand cmd;
        private SqlDataReader Dr;
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
            const string message = "Are you sure that you would like to cancel the application?";
            const string caption = "Cancel Confiramtion";

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
            ModifyBookForm mbf = new ModifyBookForm(dataGridViewBooks);
            mbf.Show();

            // or the version bellow for updating values directly on the dataGridView Celles
            //index of the selected row
            //int index = dataGridViewBooks.CurrentRow.Index;
            //string IsbnCode = dataGridViewBooks[0, index].Value.ToString();
            //Book b1 = DbDataContext.Books.Single<Book>(x => x.IsbnCode == IsbnCode);

            //DataGridViewCell C1 = dataGridViewBooks.Rows[index].Cells[0];
            //C1.ReadOnly = true;
            //if (dataGridViewBooks[1, index].Value != null)
            //    b1.Title= dataGridViewBooks[1,index].Value.ToString();
            //if (dataGridViewBooks[3, index].Value != null)
            //    b1.NbrPages= (int)dataGridViewBooks[3, index].Value;
            //if(dataGridViewBooks[4, index].Value!=null)
            //    b1.ReleaseDate=(DateTime)dataGridViewBooks[4, index].Value;
            //DbDataContext.SubmitChanges();
            //MessageBox.Show("The Book has been updated...");
        }
        // If you want to implement both "*" and "?"
        private static String LikeToRegular(String text)
        {
            return "^" + Regex.Escape(text).Replace("?", ".").Replace("%", ".*") + "$";
        }
        private void txt_FilterValue_TextChanged(object sender, EventArgs e)
        {
            //Connected Mode

            List<Book> lstOfBooks = new List<Book>();
            try
            {
                conx.Open();
                cmd = new SqlCommand();
                cmd.Connection = conx;
                cmd.CommandTimeout = 10;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select *  from book where Title like @filter";
                //cmd.Parameters.AddWithValue("@filter", txt_FilterValue.Text); //or
                cmd.Parameters.Add("@filter", SqlDbType.Text);
                cmd.Parameters["@filter"].Value = txt_FilterValue.Text;
                //Or
               // cmd.Parameters.Add("@filter", SqlDbType.Text).Value= txt_FilterValue.Text;
                
                using (Dr = cmd.ExecuteReader()) //or  using(Dr = cmd.ExecuteReader(CommandBehavoir.CloseConnection)) {
                {
                    while (Dr.Read())
                    {
                        Book b1 = new Book();
                        b1.IsbnCode = Dr.GetString(0);
                        b1.Title = Dr.GetString(1);
                        if (!Dr.IsDBNull(2))
                            b1.CoverImage = (byte[])Dr.GetValue(2);
                        if (!Dr.IsDBNull(3))
                            b1.NbrPages = Dr.GetInt32(3);
                        if (!Dr.IsDBNull(4))
                            b1.ReleaseDate = Dr.GetDateTime(4);
                        lstOfBooks.Add(b1);
                    }
                }

                dataGridViewBooks.DataSource = lstOfBooks;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conx.State == ConnectionState.Open)
                {
                    conx.Close();
                }
            }







            //try
            //{

            //    string text = txt_FilterValue.Text;
            //    MessageBox.Show(LikeToRegular(text));

            //    if (text == "")
            //        dataGridViewBooks.DataSource = DbDataContext.Books;
            //    else
            //    {
            //        string criteria = LikeToRegular(text);
            //        dataGridViewBooks.DataSource = (from x in DbDataContext.Books.AsEnumerable<Book>()
            //                                        where Regex.IsMatch(x.Title, LikeToRegular(text))
            //                                        select x).ToList<Book>();
            //    }

            //    }
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private ErrorProvider ep = new ErrorProvider();
        

        private void dataGridViewBooks_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            if (e.ColumnIndex==0)
            {
                string isbnCode = e.FormattedValue.ToString();
                Control edit = dataGridViewBooks.EditingControl;
                if (edit != null && isbnCode==string.Empty)
                {
                    e.Cancel = true;
                    ep.SetError(edit, "The value is required");
                    ep.SetIconAlignment(edit, ErrorIconAlignment.MiddleLeft);
                    ep.SetIconPadding(edit, -20); // icon displays on left side of cell
                }
            }
            if (e.ColumnIndex == 3)
            {
                int val;
                Control edit = dataGridViewBooks.EditingControl;
                if (edit != null && !int.TryParse(e.FormattedValue.ToString(), out val))
                {
                    e.Cancel = true;
                    ep.SetError(edit, "Numeric value required");
                    ep.SetIconAlignment(edit, ErrorIconAlignment.MiddleLeft);
                    ep.SetIconPadding(edit, -20); // icon displays on left side of cell
                }
            }
        }

        private void dataGridViewBooks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewBooks.Rows[e.RowIndex].ErrorText = String.Empty;
            ep.Clear();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        
    }
}
