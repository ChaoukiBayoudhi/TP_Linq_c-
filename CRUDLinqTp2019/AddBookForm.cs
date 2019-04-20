using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> 405170a7e06592cee818cf10ef8d784288db1093
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
<<<<<<< HEAD
            AddAuthorForm fa = new AddAuthorForm(dataGridViewAuthors, txt_IsbnCode.Text);
=======
            AddAuthorForm fa = new AddAuthorForm();
>>>>>>> 405170a7e06592cee818cf10ef8d784288db1093
            fa.Show();
        }

        private void bt_AddBook_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {

                //Create a Book object
                Book b1 = new Book();
                //Initialize Properties
                b1.IsbnCode = txt_IsbnCode.Text;
                b1.Title = txt_Title.Text;
                b1.NbrPages = int.Parse(txt_NbrPages.Text);


                //insert The Photo from the PictureBox
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] CoverImage_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(CoverImage_aray, 0, CoverImage_aray.Length);
                b1.CoverImage = CoverImage_aray;


                //Add b1 to Books then to the Database
                ListOfBooksForm.DbDataContext.Books.InsertOnSubmit(b1);
                ListOfBooksForm.DbDataContext.SubmitChanges();
                MessageBox.Show("The book has been added successfully");

                //update the content Of the dataGridView of Books
                dataGridViewBooks1.DataSource = null;
                dataGridViewBooks1.DataSource = ListOfBooksForm.DbDataContext.Books;

                //Adding  tuples to the table BookAuthors

                
                using (SqlConnection conx = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False"))
                {
                    conx.Open();

                    foreach (DataGridViewRow row in dataGridViewAuthors.Rows)
                    {
						//insert the tuple into BookAuthors
                        int idAuthor = (int)row.Cells["Id"].Value;
                        SqlCommand cmd = new SqlCommand("insert into BookAuthors values(@IsbnCode, @IdAuthor)", conx);
                        cmd.Parameters.Add("@IsbnCode", SqlDbType.NVarChar).Value = txt_IsbnCode.Text;
                        cmd.Parameters.Add("@IdAuthor", SqlDbType.Int).Value = idAuthor;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
=======
            //Create a Book object
            Book b1 = new Book();
            //Initialize Properties
            b1.IsbnCode = txt_IsbnCode.Text;
            b1.Title = txt_Title.Text;
            b1.NbrPages = int.Parse(txt_NbrPages.Text);


            //insert The Photo from the PictureBox
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] CoverImage_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(CoverImage_aray, 0, CoverImage_aray.Length);
            b1.CoverImage = CoverImage_aray;


            //Add b1 to Books then to the Database
            ListOfBooksForm.DbDataContext.Books.InsertOnSubmit(b1);
            ListOfBooksForm.DbDataContext.SubmitChanges();
            MessageBox.Show("The book has been added successfully");

            //update the content Of the dataGridView of Books
            dataGridViewBooks1.DataSource = null;
            dataGridViewBooks1.DataSource = ListOfBooksForm.DbDataContext.Books;
>>>>>>> 405170a7e06592cee818cf10ef8d784288db1093
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = @"c:\";
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;
            ofd.Title = "Select an image";
            ofd.Filter = "All images types|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String f1 = ofd.FileName;
                pictureBox1.ImageLocation = f1;
                pictureBox1.Image = Image.FromFile(f1); // Or =new Bitmap(f1);
            }
        }
    }
}
