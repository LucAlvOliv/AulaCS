using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1505_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 6;
        }

        public void Desacelerar()
        {
            Velocidade -= 3;
        }
    }
}
