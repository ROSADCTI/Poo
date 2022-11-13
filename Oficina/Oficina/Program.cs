using System;

namespace Oficina
{
     class Program
    {
        static void Main(string[] args)
        {
            Carro C = new Carro("fiat", "Argo S", 2023, false, 40, "metalico");

            C.status();
           
             
           Console.WriteLine(C.sistuacaoMotor());

             
           Console.WriteLine(C.ligarMotor());
           
            Console.WriteLine(C.DesligarMotor());


        }

        
    }
}
