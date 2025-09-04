using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double preco {  get; set; }
        public int IdCategoria { get; set; }
        public string IdRespCadastro { get; set; }


        public DataTable Listar()
        {
            string comando = "SELECT * FROM produtos";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }



    }
}
