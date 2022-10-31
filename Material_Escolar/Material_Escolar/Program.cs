using System;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Material_Escolar
{
    class Program
    {
        static void Main(string[] args)
        {
         Caneta Ct = new Caneta("verde","BIC",90,"Acrilico",false,false,true);
            Lapis L = new Lapis("BiC", 15, 0.5, "verde", "fino",false,60);
            Caderno C = new Caderno("Duro", "Tilibra", 200, 8, true, false, false,true);
            Borracha B = new Borracha("multicor", "pelikan", 80, "dupla", "plástico", 9f, true);
            Apontador_com_Depósito A = new Apontador_com_Depósito(60, 23, 16, "Laranja", "Leonora", "Acrilica", "Retangula", false, true);

           
             Ct.status();
             Ct.Estourado();
             Ct.Tampa();
             Ct.Cair();
             Ct.Escrever();
            
            L.status();
            L.Escrever();
             
            C.status();
            C.caido();
            C.Escrever();
             
             B.status();
             B.caido();
             B.apagar();
             
            A.status();
            A.Quebrado();
            A.laminacega();
            A.aponta();













        }

    }

}


