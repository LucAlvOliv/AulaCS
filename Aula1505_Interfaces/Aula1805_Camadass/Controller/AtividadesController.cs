using Aula1805_Camadass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1805_Camadass.Controller
{
    class AtividadesController
    {
        List<Atividade> minhasAtividades = new List<Atividade>();

        public int UltimoIdUtilizado { get; private set; }
        public AtividadesController()
        {
            UltimoIdUtilizado = 0;
        }

        //Salvar
        public void Salvar(Atividade atividade)
        {
            UltimoIdUtilizado++;
            atividade.AtividadeID = UltimoIdUtilizado;
            minhasAtividades.Add(atividade);
        }
        //Listar
        public List<Atividade> Listar()
        {
            return minhasAtividades;
        }
        //BuscarPorID
        public Atividade BuscarPorId(int id)
        {
            foreach (Atividade a in minhasAtividades)
            {
                if (a.AtividadeID == id)
                {
                    return a;
                }
            }
            return null;
        }
        //Editar
        public void Editar(Atividade atividadeAtualizada)
        {
            foreach (Atividade a in minhasAtividades)
            {
                if(a.AtividadeID == atividadeAtualizada.AtividadeID)
                {
                    a.Nome = atividadeAtualizada.Nome;
                    a.Ativo = atividadeAtualizada.Ativo;
                }
            }
        }
        //Excluir
        public void Excluir(Atividade atividade)
        {
            minhasAtividades.Remove(atividade);
        }
    }
}
