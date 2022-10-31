using System;


namespace Material_Escolar
{
    public class Caneta
    {
        private string cor;
        private string marca;
        private int percentualCarga;
        private string material;
        private bool estourada;
        private bool caida;
        private bool tampada;
        public Caneta(string c, string m, int p, string mt, bool e, bool C, bool t)
        {
            this.cor = c;
            this.marca = m;
            this.percentualCarga = p;
            this.material = mt;
            this.estourada = e;
            this.caida = C;
            this.tampada = t;
        }
        public string getCor()
        {
            return this.cor;
        }
        public void setcor(string c)
        {
            this.cor = c;
        }
        public string getmarca()
        {
            return this.marca;
        }
        public void setmarca(string m)
        {
            this.marca = m;
        }
        public int getpercentualCarga()
        {
            return this.percentualCarga;
        }
        public void setpercentualCarga(int p)
        {
            this.percentualCarga = p;
        }
        public string getmaterial()
        {
            return this.material;
        }
        public void setmaterial(string mt)
        {
            this.material = mt;
        }
        public bool getestourada()
        {
            return this.estourada;
        }
        public void setestourada(bool e)
        {
            this.estourada = e;
        }
        public bool getcaida()
        {
            return this.caida;
        }
        public void setcaida(bool C)
        {
            this.caida = C;
        }

        public void status()
        {
            Console.WriteLine("\n\n **Sombre a Caneta:**");
            Console.WriteLine("\n Cor: " + this.cor);
            Console.WriteLine("\n Marca: " + this.marca);
            Console.WriteLine("\n PercetualCarga: " + this.percentualCarga);
            Console.WriteLine("\n Material: " + this.material);
            Console.WriteLine("\n Estourada: " + this.estourada);
            Console.WriteLine("\n Caida: " + this.caida);
            Console.WriteLine("\n Tampada: " + this.tampada);
        }
        public void Estourado()
        {
            if (estourada == true)
            {
                Console.WriteLine("\n Caneta esta estourada.Troca a Caneta.");
            }
            else
            {
                Console.WriteLine("\n Não esta estourada.");
            }
        }
        public void Cair()
        {
            if (caida == false)
            {
                Console.WriteLine("\n A caneta não esta caida.");
            }
            else
            {
                Console.WriteLine("\n Caneta caida.");
            }
        }
        public void Tampa()
        {
            if (tampada == false)
            {
                Console.WriteLine("\n A Caneta não esta tampada.");
            }
            else
            {
                Console.WriteLine("\n A caneta esta tampada.");
            }
        }
        public void Escrever()
        {
            if (caida == true)
            {
                Console.WriteLine("\n Pegue caneta do chão.");
            }
            else
            {
                if (estourada == true)
                {
                    Console.WriteLine("\n A caneta esta estourada.");
                }
                else
                {
                    if (tampada == true)
                    {
                        Console.WriteLine("\n Destampe a caneta.");
                    }
                    else
                    {
                        if (percentualCarga <= 0)
                        {
                            Console.WriteLine("\n A caneta esta sem carga.");
                        }
                        else
                        {
                            Console.WriteLine("\n Você pode escrever.");
                        }

                    }
                }
            }


        }

    }
}
