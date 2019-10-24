using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LojaVirtual.DataBase
{
    public class Conexao
    {
        private const string ConnectionString = "Server=localhost; Database=usuarios; Uid=igor; Pwd=852310;";
        private MySqlConnection myConn;

        public Conexao()
        {
            myConn = new MySqlConnection(ConnectionString);
        }

        public void Fechar()
        {
            if (myConn.State != System.Data.ConnectionState.Closed)
                myConn.Close();
        }

        public void Executar(MySqlCommand cmd)
        {
            try
            {
                if (myConn.State != System.Data.ConnectionState.Open)
                    myConn.Open();

                cmd.Connection = myConn;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 1062: throw new Exception("Este registro já está sendo utilizado.");
                    case 1451: throw new Exception("Atenção! Este registro não pode ser excluído no momento (chave estrangeira).");
                    default: throw;
                }
            }
            finally
            {
                Fechar();
            }
        }



        public DataTable Pesquisar(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection = myConn;

                DataTable dt = new DataTable();

                MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);

                adpt.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                Fechar();
                throw;
            }

        }

    }
}
