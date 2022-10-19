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

namespace EntregaEncomendas
{
    public partial class Form1 : Form
    {

        SqlConnection sqlCon = null;

        //Data Source=.\SQLEXPRESS;Integrated Security=True;Connect Timeout=30
        private string strCon = "Data Source = localhost; Initial Catalog = entregas; Persist Security Info=True;User ID = sa; Password=123456";
        private string strSql = "";

        SqlConnection objConect = null; //
        SqlCommand objCommand = null; //

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entregasDataSet.encomendas' table. You can move, or remove it, as needed.
            this.encomendasTableAdapter.Fill(this.entregasDataSet.encomendas);


            using (SqlConnection con = new SqlConnection(strCon))
            {
                SqlCommand cmd = new SqlCommand("SELECT nome FROM moradores", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                txtNome.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


        }
    }
}
