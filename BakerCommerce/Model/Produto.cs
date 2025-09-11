﻿using MySqlConnector;
using System;
using System.Data;

namespace BakerCommerce.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco {  get; set; }
        public int IdCategoria { get; set; }
        public int IdRespCadastro { get; set; }


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

        public bool Apagar()

        {

            string comando = "DELETE FROM produtos WHERE id = @id";

            Banco conexaoBD = new Banco();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);

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

        public bool Cadastrar()

        {

            string comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) VALUES " +

                "(@nome, @preco, @id_categoria, @id_respcadastro)";

            Banco conexaoBD = new Banco();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", Nome);

            cmd.Parameters.AddWithValue("@preco", Preco);

            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);

            cmd.Parameters.AddWithValue("@id_respcadastro", IdRespCadastro);

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

        public bool Modificar()

        {

            string comando = "UPDATE produtos SET nome = @nome, " +

                "preco = @preco, id_categoria = @id_categoria WHERE id = @id";

            Banco conexaoBD = new Banco();

            MySqlConnection con = conexaoBD.ObterConexao();

            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", Nome);

            cmd.Parameters.AddWithValue("@preco", Preco);

            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);

            cmd.Parameters.AddWithValue("@id", Id);

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
