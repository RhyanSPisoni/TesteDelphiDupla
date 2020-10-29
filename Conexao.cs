using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppLojaJogos
{
    class Conexao
    {
        MySqlConnection mCon = new MySqlConnection();
        //Construtor
        public Conexao()
        {
            mCon.ConnectionString = @"Persist Security Info = False; server = localhost; database = ljgames; uid = root; password = ;";
        }

        //Método Conectar
        public MySqlConnection conectar()
        {
            if (mCon.State == System.Data.ConnectionState.Closed)
            {
                mCon.Open();
            }
            return mCon;
        }

        //Método Desconectar
        public void desconectar()
        {
            if (mCon.State == System.Data.ConnectionState.Open)
            {
                mCon.Close();
            }
        }
    }
}
