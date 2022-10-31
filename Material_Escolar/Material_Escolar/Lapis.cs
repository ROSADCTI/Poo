using System;

namespace Material_Escolar
{
    public class Lapis
    {
        private string   marca;
        private int tamanho;
        private double   ponta;
        private string   cor;
        private string   tipo;
        private bool apontada;
        private int percentualGrafite;

       public Lapis(string marca, int tamanho, double ponta, string cor, string tipo,bool apontada,int pg)
        {
            this.marca = marca;
            this.tamanho = tamanho;
            this.ponta = ponta;
            this.cor = cor;
            this.tipo = tipo;
            this.apontada = apontada;
            this.percentualGrafite = pg;
        }
        public string getmarca()
        {
            return this.marca;
        }
        public void setmarca(string marca)
        {
            this.marca = marca;
        }
        public int gettamanho()
        {
            return this.tamanho;
        }
        public void settamanho(int tamanho)
        {
            this.tamanho = tamanho;
        }
        public double getponta()
        {
            return this.ponta;
        }
        public void setponta(double ponta)
        {
            this.ponta = ponta;
        }
        public string gettipo()
        {
            return this.cor;
        }
        public void settipo(string tipo)
        {
            this.tipo = tipo;
        }
        public bool getapontada()
        {
             return this.apontada;
        }
        public void setapontada(bool apontada)
        {
            this.apontada = apontada;   
        }
        public int getpercentualGrafite()
        {
            return this.percentualGrafite;  
        }
        public void setpercentualGrafite(int pg)
        {
            this.percentualGrafite = pg;
        }
           public void status()
        {
            Console.WriteLine("\n\n *** Lápis:*** " );
            Console.WriteLine("\n marca: " + this.marca);
            Console.WriteLine("\n tamanho: " + this.tamanho +" cm ");
            Console.WriteLine("\n ponta: " + this.ponta +" mm ");
            Console.WriteLine("\n cor: " + this.cor);
            Console.WriteLine("\n tipo: " + this.tipo);
            Console.WriteLine("\n apontada: " + this.apontada);
            Console.WriteLine("\n percentualGrafite: " + this.percentualGrafite);
        }

        public void Escrever()
        {
            if(apontada == true)
            {
                Console.WriteLine("\n Escrever. ");
            }
            else
            {
                if(percentualGrafite >= 20)
                {
                    Console.WriteLine("\n Aponte o lápis para escrever. ");
                }
                else
                {
                    Console.WriteLine("\n Troca lápis.");
                }
            }
        }

    }


}
