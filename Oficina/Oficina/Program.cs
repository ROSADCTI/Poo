using System;

namespace Oficina
{
     class Program
    {
        static void Main(string[] args)
        {
            Carro C = new Carro("fiat", "Argo ", 2023, true, 30, "metalico");
            Pneu p = new Pneu( 14, " Goodyear");

            C.status();
           
             
          Console.WriteLine(C.sistuacaoMotor());    
          Console.WriteLine(C.ligarMotor());
           
            Console.WriteLine(C.DesligarMotor());
            Console.WriteLine(C.acelerar(20));
            Console.WriteLine(C.acelerar(50));
            Console.WriteLine(C.acelerar(70));
           
            Console.WriteLine(C.frear(50));
            Console.WriteLine(C.frear(80));
            Console.WriteLine(C.frear(60));
            Console.WriteLine(C.frear(15));
           
            p.exibir();   //Pneu.

            




        }


    }
}
