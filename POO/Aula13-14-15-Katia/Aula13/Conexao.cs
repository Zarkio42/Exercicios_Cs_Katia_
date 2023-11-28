using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    public class Conexao
    {
        static private string servidor = "localhost";
        static private string database = "bd_banco";
        static private string user = "root";
        static private string senha = "cursoads";
        static private string stringcon = $"server={servidor};user={user};pwd={senha};database={database}";

        MySqlConnection cn;

        public bool Conectar()
        {
            bool resultado = false;

            try
            {
                cn = new MySqlConnection(stringcon);
                cn.Open();
                resultado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro." + ex);
            }
            return resultado;

        }

        public void Desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public bool Executa(string sql)
        {
            bool resultado = false;

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, cn);
                comando.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }

        public DataTable Retorna(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, cn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.Write("Erro." + ex);
            }
            return dt;
        }
    }
}
