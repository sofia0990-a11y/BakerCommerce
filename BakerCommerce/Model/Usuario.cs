﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NameCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        /*Cadastrar
        * Logar
        * Modificar
        * Remover
        */

        public DataTable Logar()
        {

            string comando = "SELECT  * FROM usuario WHERE email = @email AND senha = senha";
            /*
            Caso vá utilizar o WHERE, empregue o uso de caracteres coringas,
            semelhante ao apresentado no metódo Cadastrar() acima.
            */
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // obter o hash da Senha:
            string senhahash = EasyEncryption.SHA.ComputeSHA1Hash(Senha);

            // Substituir os caracteres coringas(@)
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", senhahash); // Ainda falta obter o hash


            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}
