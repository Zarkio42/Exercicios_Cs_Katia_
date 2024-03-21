using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    public class Conexao
    {
        MySqlConnection conn;
        static string servidor = "localhost";
        static string database = "dbloja";
        static string senha = "cursoads";
        static string usuario = "root";
        static string strCon = $"server={servidor}; uid={usuario}; database={database}; pwd={senha}";

        private void Conectar()
        {
            try
            {
                conn = new MySqlConnection(strCon);
                conn.Open();
                Console.WriteLine("Conexão estabelecida.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Desconectar()
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Conexão encerrada.");
            }
               
        }

        public bool Executa(string sql)
        {
            bool resultado;
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                resultado = true;
                
            }
            catch(Exception ex)
            {
                resultado = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return resultado;
        }

        public DataTable Retorna(string sql)
        {
            try
            {
                Conectar();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
            
            
        }
    }
}
