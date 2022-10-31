using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Material_Escolar
{ public class Borracha

    {
        private string cor;
        private string marca;
        private int    percentual;
        private string formato;
        private string material;
        private float  peso;
        private bool   caida;


        public Borracha(string cor, string marca, int percentual, string formato, string material, float peso, bool caida)
        {
            this.cor = cor;
            this.marca = marca;
            this.percentual = percentual;
            this.formato = formato;
            this.material = material;
            this.peso = peso;
            this.caida = caida;
        }
        public string getcor()
        {
            return this.cor;
        }
        public void setcor(string cor)
        {
            this.cor = cor;
        }
        public string getmarca()
        {
            return this.marca;
        }
        public void setmarca(string marca)
        {
            this.marca = marca;
        }
        public int getpercentual()
        {
            return this.percentual;
        }
        public void setpercentual(int percentual)
        {
            this.percentual = percentual;
        }
        public string getformato()
        {
            return this.formato;
        }
        public void setformato(string formato)
        {
            this.formato = formato;
        }
        public string getmaterial()
        {
            return this.material;
        }
        public void setmaterial(string material)
        {
            this.material = material;
        }
        public float getpeso()
        {
            return this.peso;   
        }
        public void setpeso(float peso)
        {
            this.peso = peso;
        }
        public bool getcaida()
        {
            return this.caida;
        }
        public void setcaida(bool caida)
        {
            this.caida = caida;
        }

        public void status()
        {
            Console.WriteLine("\n*** Borracha.***");
            Console.WriteLine("\n cor: " + this.cor);
            Console.WriteLine("\n marca; " + this.marca);
            Console.WriteLine("\n percentual: " + this.percentual);
            Console.WriteLine("\n formato: " + this.formato);
            Console.WriteLine("\n material: " + this.material);
            Console.WriteLine("\n peso: " + this.peso + " G");
            Console.WriteLine("\n caida: " + this.caida);
        }
        public void caido()
        {
            if (caida == true)
            {
                Console.WriteLine("\n Esta caido.");
            }
            else
            {
                Console.WriteLine("\n Não esta caido.");
            }
        }
        public void apagar()
        {
            if(caida == true)
            {
                Console.WriteLine("\n Pegar borracha.");
            }
            else
            {
                if (percentual >= 15)
                {
                    Console.WriteLine("\n Continua usado a borrcha.");
                }
                else
                {
                    Console.WriteLine("\n Troca a borracha.");
                }
            }
        }
    } 
}