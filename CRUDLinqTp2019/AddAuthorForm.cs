using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDLinqTp2019
{
    public partial class AddAuthorForm : Form
    {
        private DataGridView dataGridViewAuthors;
        private string IsbnCodeOfBook;

        public AddAuthorForm()
        {
            InitializeComponent();
        }

        public AddAuthorForm(DataGridView dataGridViewAuthors, string IsbnCodeOfBook)
        {
            this.dataGridViewAuthors = dataGridViewAuthors;
            this.IsbnCodeOfBook = IsbnCodeOfBook;
            InitializeComponent();
        }

        private void bt_AddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Id.DropDownStyle == ComboBoxStyle.Simple)
                {
                    using (SqlConnection conx = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False"))
                    {
                        conx.Open();

                        SqlCommand cmd = new SqlCommand("insert into Author(Name,Nationality,BirthDay) values(@AuthorName, @AuthorNationality, @AuthorBirthDay)", conx);
                        //or these two lines
                        //cmd.Connection = conx;
                        //cmd.CommandText = "insert into Author(Name,Nationality,BirthDay) values(@AuthorName, @AuthorNationality, @AuthorBirthDay)";

                        cmd.Parameters.Add("@AuthorName", SqlDbType.Text).Value = txt_Name.Text;
                        cmd.Parameters.Add("@AuthorNationality", SqlDbType.Text).Value = cmb_Nationality.Text;
                        cmd.Parameters.Add("@AuthorBirthDay", SqlDbType.DateTime).Value = dtp_BirthDay.Value;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Author has been successfuly added...");
                    }//fin using
                }//fin if
                    //shown authors in the datagridView
                    List<object> lstAuthors;
                    if (dataGridViewAuthors.DataSource == null)
                    {
                        lstAuthors = new List<object>();
                    }
                    else
                    {
                        lstAuthors = ((IEnumerable)dataGridViewAuthors.DataSource).Cast<object>().ToList();
                    }
                
                    Author AddedAuthor = ListOfBooksForm.DbDataContext.Authors.Single<Author>(a => a.Id == int.Parse(cmb_Id.Text));
                    lstAuthors.Add(AddedAuthor);
                    dataGridViewAuthors.DataSource = null;
                    dataGridViewAuthors.DataSource = lstAuthors;

                    
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        





        }

        private void AddAuthorForm_Load(object sender, EventArgs e)
        {

            cmb_Id.DropDownStyle = ComboBoxStyle.Simple;

            int idAuthor;
            //Get the id of the latest Author;
            List<Author> lstAuthor = (from x in ListOfBooksForm.DbDataContext.Authors
                                select x).ToList<Author>();
            
            if (lstAuthor.Count==0)
            {
                idAuthor = 100;//the first Author to be Added
            }
            else
            {
                Author LastAuthor = lstAuthor[lstAuthor.Count - 1];
                idAuthor = LastAuthor.Id+ 10;//The key is incremented by 10 every time
            }

            cmb_Id.Text = idAuthor.ToString();
            cmb_Id.Enabled = false;
        }

        private void chk_ExistingAuthor_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ExistingAuthor.Checked)
            {
                cmb_Id.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb_Id.DataSource = (from x in ListOfBooksForm.DbDataContext.Authors
                                     select x.Id).ToList<int>();
                txt_Name.Enabled = false;
                cmb_Nationality.Enabled = false;
                dtp_BirthDay.Enabled = false;
                cmb_Id.Enabled = true;
            }
            else
            {
                cmb_Id.DropDownStyle = ComboBoxStyle.Simple;
                cmb_Id.Text = string.Empty;
                int idAuthor;
                //Get the id of the latest Author;
                List<Author> lstAuthor = (from x in ListOfBooksForm.DbDataContext.Authors
                                          select x).ToList<Author>();
                
                if (lstAuthor.Count == 0)
                {
                   
                    idAuthor = 100;//the first Author to be Added
                }
                else
                {
                    Author LastAuthor = lstAuthor[lstAuthor.Count - 1];
                    idAuthor = LastAuthor.Id + 10;//The key is incremented by 10 every time
                    //MessageBox.Show(idAuthor.ToString());
                }
                cmb_Id.Text = idAuthor.ToString();
                txt_Name.Clear();
                cmb_Id.SelectedIndex = 0;
                dtp_BirthDay.Value = DateTime.Now;
                txt_Name.Enabled = true;
                cmb_Nationality.Enabled = true;
                dtp_BirthDay.Enabled = true;
                cmb_Id.Enabled = false;
            }
            
        }

        private void cmb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author auth = ListOfBooksForm.DbDataContext.Authors.Single<Author>(x => x.Id == int.Parse(cmb_Id.Text));
            txt_Name.Text = auth.Name;
            cmb_Nationality.Text = auth.Nationality;
            dtp_BirthDay.Value = auth.BirthDay ?? DateTime.Now;
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
