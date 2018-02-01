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
        Dados.dados dc = new Dados.dados();

        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        
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
            // TODO: This line of code loads data into the 'scheduleDataSet.cadastro' table. You can move, or remove it, as needed.
            this.cadastroTableAdapter.Fill(this.scheduleDataSet.cadastro);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Carrega();
        }

        private void btn_grid_Click(object sender, EventArgs e)
        {
            All form = new All();
            form.ShowDialog();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
           
            dc.name = txb_name.Text;
            dc.phone = txb_phone.Text; 

                    conect.inserir(dc, null);
                    MessageBox.Show("CADASTRADO COM SUCESSO");
                    txb_name.Text = "";
                    txb_phone.Text = "";
                
    }

        private void btn_able_Click(object sender, EventArgs e)
        {
            txb_phone.Enabled = true;
            txb_phone.Text = "";
        }
    }
}
