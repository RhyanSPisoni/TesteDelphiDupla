using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLojaJogos
{
    class Cadastro
    {
        Conexao conexao = new Conexao();
        public string mensagem;
        MySqlCommand cmd = new MySqlCommand();

        public Cadastro(String Nome, String Email, String Senha)
        {

            cmd.CommandText = "Insert into tbusuario (Nome, Email, Senha) Values(@Nome, @Email, @Senha)";
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();

                this.mensagem = "Cadastrado com Sucesso";
            }
            catch (Exception e)
            {
                this.mensagem = "Você não está online, ou digitou algo repetido/errado";
            }
        }
    }
}
