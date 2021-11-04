using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_avulso
{
    class TicketsAvulso
    {
        public List<long> IdCartao = new List<long> ();
        public List<long> IdCliente = new List<long> ();
        List<long> Soma = new List<long>();
        List<long> Resto = new List<long>();
        List<long> Peso = new List<long> {2,3,4,5,6,7,8,9,2,3 };
        List<long> resultado = new List<long>();
        long SomaCalc02 = 0;

        

        public void Calc01()
        {
            for (int i = 0; i <= 0; i++)
            {
                IdCliente.AddRange(IdCliente);
            }
            IdCliente.Insert(0, IdCliente[2]);
            IdCliente.Insert(1, IdCliente[4]);
            for(int i =0; i<= 9; i++)
            {
                long soma01 = IdCartao[i];
                long soma02 = IdCliente[i];
                long resultado = soma01 + soma02;
                long div = resultado % 10;
                Resto.Add(div);
                Soma.Add(resultado);
            }
            Console.WriteLine("SOMA DO NUMERO DO CLIENTE COM O CODIGO DO CARTÃO:\n");
            foreach (int iten in Soma)
            {
                Console.Write(iten);
            }
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine("RESTO ENCONTRADO DO PRIMEIRO CALCULO:\n");
            foreach (int iten in Resto)
            {
                Console.Write(iten);
            }
        }

        public void Calc02()
        {
            Resto.Reverse();
            for (int i = 0; i <= 9; i++)
            {
                
                long soma01 = Resto[i];
                long soma02 = Peso[i];
                SomaCalc02 += (soma01 * soma02);
            }
            SomaCalc02 = (SomaCalc02 * 10) % 11;
            Resto.Reverse();
            if (SomaCalc02 != 10)
            {
                resultado.AddRange(Resto);
                resultado.Insert(10, SomaCalc02);
            }
            else
            {
                resultado.AddRange(Resto);
                resultado.Insert(10, 0);
            }
            Console.WriteLine("\n---------------------------------\n");
            Console.Write("PRIMEIRO DIGITO VERIFICADOR\n");
            foreach (long itens in resultado)
            {
                Console.Write(itens);
            }

            /*Console.WriteLine("\n---------------------------------\n");
            foreach (int iten in Resto)
            {
                Console.Write(iten);
            }
            Console.WriteLine();
            foreach (int iten in Resto)
            {
                Console.Write(iten);
            }
            Console.WriteLine("\n**************************\n");
            foreach (int iten in Peso)
            {
                Console.Write(iten);
            }

            Console.WriteLine("\n**************************\n");

            foreach (int iten in Resto)
            {
                Console.Write(iten);
            }*/
        }

    }

}


