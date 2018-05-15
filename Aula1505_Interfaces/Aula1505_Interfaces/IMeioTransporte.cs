using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1505_Interfaces
{
    interface IMeioTransporte
    {
        int Velocidade { get; set; }

        void Acelerar();
        void Desacelerar();

    }
}
