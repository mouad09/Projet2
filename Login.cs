using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ENTREPRISE
{
    public partial class Login : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=.;Initial Catalog=GESTION_ENTREPRISE;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            


        }

      

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                bool tr = false;
                string Query = "select * from LoginUti";
                SqlCommand cmd = new SqlCommand(Query, cnx);
                cnx.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (txtUser.Text.Equals(rd[0].ToString()) && txtmdp.Text.Equals(rd[2].ToString()))
                    {
                        tr = true;
                        break;
                    }
                }
                if (tr == true)
                {
                    this.Hide();
                    Form1 fr = new Form1();
                    fr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nom Utilisateur ou mot de passe Incorrect !!");
                }
                rd.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cnx.Close();
        }
    }
}
