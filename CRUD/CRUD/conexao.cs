using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public class Conexao
    {
        public string conec = "SERVER=localhost; DATABASE=crud; UID=root; PWD=; POT=; ";
        public MySqlConnection con = null;

        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
                HttpContext.Current.Response.Write("");
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("Erro ao conectar" + ex);
                
            }
        }
        public void Fecharcon() 
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write("Erro ao conectar" + ex);

            }
        }
    }
}