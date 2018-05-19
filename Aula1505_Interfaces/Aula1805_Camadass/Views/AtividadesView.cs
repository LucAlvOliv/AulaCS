using Aula1805_Camadass.Controller;
using Aula1805_Camadass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1805_Camadass.Views
{
    class AtividadesView
    {
        AtividadesController ac = new AtividadesController();
        public void ExibirMenu()
        {
            int opcao = 6;
            do
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("= 1) Cadastrar Atividade ");
                Console.WriteLine("= 2) Listar Atividades ");
                Console.WriteLine("= 3) Editar Atividade ");
                Console.WriteLine("= 4) Excluir Atividade ");
                Console.WriteLine("= 6) --SAIR-- ");
                Console.WriteLine("================================");

                Console.WriteLine("Digite sua opcao: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarAtividade();
                        break;

                    case 2:
                        ExibirAtividadesCadastradas();
                        break;

                    case 3:
                        EditarAtividadeCadastrada();
                        break;

                    case 4:
                        ExcluirAtividadeCadastrada();
                        break;

                    default:
                        break;
                }
                Console.ReadKey();
            } while (opcao != 6);
        }

        private void ExcluirAtividadeCadastrada()
        {
            Console.Clear();
            ExibirAtividadesCadastradas();
            Console.WriteLine("-- Excluindo atividades cadastradas --");


            Console.WriteLine("Digite o id da atividade a ser excluida");
            int id = int.Parse(Console.ReadLine());
            Atividade atividade = ac.BuscarPorId(id);
            if (atividade != null)
            {
                ac.Excluir(atividade);
            }
            else
            {
                Console.WriteLine("Atividade não encontrada");
            }
        }

        private void EditarAtividadeCadastrada()
        {
            Console.Clear();
            ExibirAtividadesCadastradas();
            Console.WriteLine("-- Editando atividades cadastradas --");

            Atividade atividade = new Atividade();

            Console.WriteLine("Digite o id da atividade a ser alterada");
            atividade.AtividadeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo nome:");
            atividade.Nome = Console.ReadLine();
            Console.WriteLine("Ativo? (s/n)");
            atividade.Ativo = Console.ReadLine() == "s" ? true : false;

            ac.Editar(atividade);
        }

        private void ExibirAtividadesCadastradas()
        {
            Console.Clear();
            Console.WriteLine("-- Exibindo atividades cadastradas --");
            foreach (Atividade a in ac.Listar())
            {
                Console.WriteLine(" - Dados Atividade - ");
                Console.WriteLine("Id: " + a.AtividadeID);
                Console.WriteLine("Nome : " + a.Nome);
                Console.WriteLine("Ativo: " + a.Ativo);
                Console.WriteLine("--");
            }
            Console.WriteLine("--FIM DA LISTA--");
        }

        private void CadastrarAtividade()
        {
            Console.Clear();
            Console.WriteLine("-- Cadastrando nova atividade --");
            Atividade atividade = new Atividade();
            Console.WriteLine("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();
            atividade.Ativo = true;
            ac.Salvar(atividade);
        }
    }
}
