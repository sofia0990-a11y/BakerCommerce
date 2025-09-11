using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    public class OrdemComanda
    {
         public int Id { get; set; }
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int IdQuantidade { get; set; }
        public int IdResp {  get; set; }
        public DateTime DataAdic {  get; set; }
        public bool Situacao { get; set; }


        // Listar (SELECT View_fichas
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



        // Cadastrar ( INSERT na ordens_comandas)
        public bool Cadastrar()

        {

            string comando = "INSERT INTO orden_comandas (id_ficha, id_produto, id_quantidade, id_resp) VALUES " +

                "(@id_ficha, @id_produto, @id_quantidade, @id_resp)";

            Banco conexaoBD = new Banco();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);

            cmd.Parameters.AddWithValue("@id_produto", IdProduto);

            cmd.Parameters.AddWithValue("@id_quantidade", IdQuantidade);

            cmd.Parameters.AddWithValue("@id_resp", IdResp);

            cmd.Prepare();

            try

            {

                if (cmd.ExecuteNonQuery() == 0)

                {

                    conexaoBD.Desconectar(con);

                    return false;

                }

                else

                {

                    conexaoBD.Desconectar(con);

                    return true;

                }

            }

            catch

            {

                conexaoBD.Desconectar(con);

                return false;

            }

        }
    }
}
