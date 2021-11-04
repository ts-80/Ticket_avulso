using System;
using System.Collections.Generic;

namespace Ticket_avulso
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketsAvulso tk = new TicketsAvulso();
            Console.Write("INFORME O CODIGO DO CARTÃO:");
            for (int i = 0; i <= 9; i++)
            {
                
                int pass=int.Parse(Console.ReadLine());
                tk.IdCartao.Add(pass);
            }
            Console.Write("INFORME O CODIGO DO CLIENTE:");
            for (int i = 0; i <= 3; i++)
            {

                int pass = int.Parse(Console.ReadLine());
                tk.IdCliente.Add(pass);
            }
            tk.Calc01();
            tk.Calc02();

            Console.ReadKey();
        }
    }
}
