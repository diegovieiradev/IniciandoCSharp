using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa" +
                    "\nDigite uma das opções abaixo:" +
                    "\n" +
                    "\n0 - Sair do programa" +
                    "\n1 - Para ler arquivos" +
                    "\n2 - Para executar a tabuada" +
                    "\n3 - Calcular média de alunos";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVO)
                {
                    Console.WriteLine("======================== Opção Ler Arquivos ==============================");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("======================== Opção Tabuada ===================================");
                    Console.WriteLine("Digite o número que deseja na tabuada! ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);

                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                }
                else
                {
                    Console.WriteLine("Opção inválida digite novamente");
                }

            }
        }
    }
}
