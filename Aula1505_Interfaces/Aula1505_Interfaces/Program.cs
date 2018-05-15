using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1505_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Carro criado, velocidade inicial: " + c.Velocidade);
            c.Acelerar();
            c.Acelerar();
            AcelerarBastante(c);
            Console.WriteLine("Carro, valocidade atual: " + c.Velocidade);

            Onibus o = new Onibus();

            Console.WriteLine("Onibus Criado, velocidade inicial: " + o.Velocidade);
            o.Acelerar();
            AcelerarBastante(o);
            o.Acelerar();
            o.Desacelerar();
            Console.WriteLine("Onibus, velocidade atual: " + o.Velocidade);

            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int  i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
