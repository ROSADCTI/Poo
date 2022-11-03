using System;

namespace Oficina
{
     class Program
    {
        static void Main(string[] args)
        {
            Carro C = new Carro("fiat", "argo", 2023, true, 162, "metalico");

            C.status();


        }
    }
}
