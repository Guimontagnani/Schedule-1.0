using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Schedule
{
    class Conect
    {
        public SqlConnection con;
        public SqlCommand cSql;
        public SqlDataReader reader = null;
        public SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public string strSql = "";

        public void conecta()
        {
            string scon = "Data Source=GUI;Initial Catalog=Schedule;Integrated Security=True";
            con = new SqlConnection(scon);
            con.Open();
        }

        public void fechar()
        {
            con.Close();
        }
        public DataSet selecionarNome(string name)
        {
            conecta();
            strSql = "select * from cadastro where name = @name";
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@name", name);
            adapter = new SqlDataAdapter(cSql);
            adapter.Fill(ds, "cadastro");
            fechar();
            return ds;
        }
        public void inserir(Dados.dados dc, string codigo)
        {
            conecta();
            if (codigo == null)
            {
                strSql = "insert into cadastro values (" + " @name, @phone)";
            }
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@name", dc.name);
            cSql.Parameters.AddWithValue("@phone", dc.phone);

            cSql.ExecuteNonQuery();
            fechar();
        }

        public void AtualizarCliente()
        {
            conecta();
            strSql = "select nome from cadastro order by name";
            cSql = new SqlCommand(strSql, con);
            reader = cSql.ExecuteReader();
        }
    }
}
