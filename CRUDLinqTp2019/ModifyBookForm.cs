using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDLinqTp2019
{
    public partial class ModifyBookForm : Form
    {
        private DataGridView dataGridViewBooks;

        public ModifyBookForm()
        {
            InitializeComponent();
        }

        public ModifyBookForm(DataGridView dataGridViewBooks)
        {
            this.dataGridViewBooks = dataGridViewBooks;
            InitializeComponent();
        }

        private void ModifyBookForm_Load(object sender, EventArgs e)
        {
            cmb_isbnCode.DataSource = (from b1 in ListOfBooksForm.DbDataContext.Books
                                       select b1.IsbnCode
                                     );
        }

        private void cmb_isbnCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isbnCode = cmb_isbnCode.Text;
            //this version is the right one
            Book b2 = ListOfBooksForm.DbDataContext.Books.Single<Book>(x => x.IsbnCode == isbnCode);
            txt_Title.Text = b2.Title;
            txt_NbrPages.Text = b2.NbrPages.ToString();
            //"??" operator to assign the current Date if the "ReleaseDate" is NULL
            dtp_ReleaseDate.Value = b2.ReleaseDate ?? DateTime.Now;

            //Show the image in the PictureBox
            if (b2.CoverImage != null)
            {
                byte[] bytesImage = b2.CoverImage.ToArray();
                if (bytesImage != null)
                {
                    using (MemoryStream ms = new MemoryStream(bytesImage))
                    {
                        using (var imageCov = Image.FromStream(ms))
                        {
                            pictureBox1.Image = (Image)imageCov.Clone();
                        }
                    }
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.student;
            }
            //if we have a multi-line result in X1 we'd use this version
            //        var x1 = (from b1 in ListOfBooksForm.DbDataContext.Books
            //         where b1.IsbnCode == isbnCode
            //         select b1).ToList<Book>();
            //         foreach (Book b1 in x1)
            //         {

            //    //        if(Rdate.HasValue)

            //         }
        }

        private void bt_ModifyBook_Click(object sender, EventArgs e)
        {
            Book b1 = ListOfBooksForm.DbDataContext.Books.Single<Book>(x => x.IsbnCode == cmb_isbnCode.Text);
            b1.Title = txt_Title.Text;
            b1.NbrPages = int.Parse(txt_NbrPages.Text);
            b1.ReleaseDate = dtp_ReleaseDate.Value;

            //insert The Photo from the PictureBox
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] CoverImage_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(CoverImage_aray, 0, CoverImage_aray.Length);
            b1.CoverImage = CoverImage_aray;

            //Update the Database, there is no InsertOnUpdate
            ListOfBooksForm.DbDataContext.SubmitChanges();
            MessageBox.Show("The selected book has been updated...");
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = (from b in ListOfBooksForm.DbDataContext.Books
                                            select b).ToList<Book>();

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
