using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class paginaInicial : System.Web.UI.Page
    {

        Conexao con = new Conexao();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtdescrição_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextPreço_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Salvar_Click(object sender, EventArgs e)
        {

            if (textnome.Text == "")
            {
                lblmensagemErro.Text = "Preencha o campo *PRODUTO*!";
                return;
            }

            btnSalvar();

            con.AbrirCon();
        }

        private void btnSalvar()
        {
            string sql;
            MySqlCommand cmd;

            con.AbrirCon();

            sql = "INSERT INTO produto (NOME_PRODUTO,DESCRICAO_PRODUTO,PRECO_PRODUTO,QUANTIDADE_PRODUTO) VALUES ( @NOME_PRODUTO, @DESCRICAO_PRODUTO, @PRECO_PRODUTO, @QUANTIDADE_PRODUTO )";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@NOME_PRODUTO", textnome.Text);
            cmd.Parameters.AddWithValue("@DESCRICAO_PRODUTO", txtdescrição.Text);
            cmd.Parameters.AddWithValue("@PRECO_PRODUTO", TextPreço.Text);
            cmd.Parameters.AddWithValue("@QUANTIDADE_PRODUTO", TextQuantidadeDoProduto.Text);


            cmd.ExecuteNonQuery();
            lblmensagemOK.Text = "Salvo com sucesso!";

            con.Fecharcon();
        }

        protected void bntEditar_Click(object sender, EventArgs e)
        {

        }

        protected void bntEcluir_Click(object sender, EventArgs e)
        {

        }

        protected void TextQuantidadeDoProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}