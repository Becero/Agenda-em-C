﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[100];
            string[] tel = new string[100];
            string[] email = new string[100];
            
            int opcao, qtd = 0;
            do
            {
                Console.WriteLine("==============Menu===============");
                Console.WriteLine("0 ------------------------- Sair.");
                Console.WriteLine("1 -------------------- Cadastrar ");
                Console.WriteLine("2 -------------------- Apresentar");                
                Console.WriteLine("3 --------------------- Pesquisar");
                Console.WriteLine("4 ----------------------- Alterar");
                Console.WriteLine("5 ----------------------- Excluir");
                Console.WriteLine("=================================");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema");
                        break;
                    case 1:
                        if (qtd >= 100)
                        {
                            Console.WriteLine("Entre em contato com Administrador para adicionar mais espaço");
                        }
                        else
                        {
                            Console.WriteLine("=================================");
                            Console.WriteLine("Entre com o nome do paciente");
                            nome[qtd] = Console.ReadLine();
                            Console.WriteLine("Entre com o Telefone do paciente");
                            tel[qtd] = Console.ReadLine();
                            Console.WriteLine("Entre com o Email do paciente");
                            email[qtd] = Console.ReadLine();
                            Console.WriteLine("=================================");                            
                            qtd++;
                        }
                        break;
                    case 2:
                        int esc;
                        Console.WriteLine("Para apresentar apenas 1 usuario digite 1, se deseja listar todos 2.");
                        esc = int.Parse(Console.ReadLine());
                        if (esc == 1)
                        {
                            Console.WriteLine("Entre com o nome a ser buscado");
                            string nomeBuscado2 = Console.ReadLine();
                            for (int x = 0; x < qtd; x++)
                            {
                                if (nome[x].ToLower().Contains(nomeBuscado2.ToLower()))
                                {
                                    Console.WriteLine("===========Paciente {0}===========", x + 1);
                                    Console.WriteLine("NOME: " + nome[x]);
                                    Console.WriteLine("TELEFONE: " + tel[x]);
                                    Console.WriteLine("EMAIL: " + email[x]);
                                    Console.WriteLine("=================================");
                                }
                            }
                        }
                        else if (esc == 2)
                        {
                            for (int y = 0; y < qtd; y++)
                            {
                                Console.WriteLine("===========Paciente {0}=====+=====", y + 1);
                                Console.WriteLine("NOME: " + nome[y]);
                                Console.WriteLine("TELEFONE: " + tel[y]);
                                Console.WriteLine("EMAIL: " + email[y]);
                                Console.WriteLine("=================================");
                            }
                        }
                        else
                            Console.WriteLine("Opção invalida");
                        break;                    
                    case 3:
                        Console.WriteLine("Entre com o nome a ser buscado");
                        string nomeBuscado = Console.ReadLine();
                        bool validacao = true;
                        for (int p = 0; p < qtd; p++)
                        {
                            if (nome[p].ToLower().Contains(nomeBuscado.ToLower()))
                            {
                                Console.WriteLine("===========Paciente {0}===========", p + 1);
                                Console.WriteLine("NOME: " + nome[p]);
                                Console.WriteLine("TELEFONE: " + tel[p]);
                                Console.WriteLine("EMAIL: " + email[p]);
                                Console.WriteLine("=================================");
                                validacao = false;
                            }
                        }
                        if (validacao)
                            Console.WriteLine("NENHUM PACIENTE COM O NOME");
                        break;
                    case 4:
                        Console.WriteLine("Entre com o nome a ser alterado");
                        string nomeEditar = Console.ReadLine().ToLower();
                        bool val = true;

                        for (int i = 0; i < qtd; i++)
                        {
                            if (nome[i].ToLower().Contains(nomeEditar.ToLower()))
                            {
                                Console.WriteLine("Entre com o novo nome do paciente");
                                nome[i] = Console.ReadLine();
                                Console.WriteLine("Entre com o novo Telefone do paciente");
                                tel[i] = Console.ReadLine();
                                Console.WriteLine("Entre com o novo Email do paciente");
                                email[i] = Console.ReadLine();
                                Console.WriteLine("=================================");
                                val = false;
                            }
                        }
                        if (val)
                            Console.WriteLine("NENHUM PACIENTE COM O NOME");
                        break;
                    case 5:
                        Console.WriteLine("Entre com o nome a ser excluido");
                        string nomeExcluir = Console.ReadLine().ToLower();
                        bool vale = true;
                        for (int i = 0; i < qtd; i++)
                        {
                            if (nome[i].ToLower().Contains(nomeExcluir))
                            {
                                nome[i] = nome[qtd - 1];
                                tel[i] = tel[qtd - 1];
                                email[i] = email[qtd - 1];
                                qtd--;                                
                                vale = false;
                            }
                        }
                        if (vale)
                            Console.WriteLine("NENHUM PACIENTE COM O NOME");
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção valida!");
                        break;
                }
                Console.WriteLine("Aperte algo para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);

        }
    }
}