using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //identificacao = id;
        }
        Conect conect = new Conect();

        //string identificacao = null;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        //int verificar = 0;
        //int clique = 0;
        public void Carrega()
        {
            ds = conect.selecionarNome(txb_name.Text);
            dt = ds.Tables["cadastro"];
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txb_name.Text = row["name"].ToString();
                    txb_phone.Text = row["phone"].ToString();
                    
                }
            }
            else
            {
                MessageBox.Show("NOT FOUND");
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Carrega();
        }
    }
}
