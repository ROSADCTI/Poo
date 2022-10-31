using System;


namespace Material_Escolar
{
    public class Caderno
    {
        private string Marca;
        private string TipoCapa;
        private int    QuantidadeFolha;
        private int    QuantidadeMateria;
        private bool   Caido;
        private bool   Sujo;
        private bool   Rasgado;
        private bool   Pauta;

        public Caderno(string tipoCapa, string marca, int quantidadeFolha, int quantidadeMateria, bool caido, bool sujo, bool rasgado, bool pauta)
        {
            TipoCapa = tipoCapa;
            Marca = marca;
            QuantidadeFolha = quantidadeFolha;
            QuantidadeMateria = quantidadeMateria;
            Caido = caido;
            Sujo = sujo;
            Rasgado = rasgado;
            Pauta = pauta;
        }

        public string getMarca()
        {
            return this.Marca;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public string getTipoCapa()
        {
            return this.TipoCapa;
        }
        public void setTipoCapa(string TipoCapa)
        {
            this.TipoCapa = TipoCapa;
        }
        public int getQuanitdaFolha()
        {
            return this.QuantidadeFolha;
        }
        public void setQuantidadeFolha(int QuantidadeFolha)
        {
            this.QuantidadeFolha = QuantidadeFolha;
        }
        public int getQuantidadeMateria()
        {
            return this.QuantidadeMateria;

        }
        public void setQantidade(int QuantidadeMateria)
        {
            this.QuantidadeMateria = QuantidadeMateria;
        }
        public bool getCaido()
        {
            return this.Caido;
        }
        public void setCaido(bool Caido)
        {
            this.Caido = Caido;
        }
        public bool getSujo()
        {
            return this. Sujo;
        }
        public void setSujo(bool Sujo)
        {
            this.Sujo = Sujo;
        }
        public bool getRasgado()
        {
            return this.Rasgado;    
        }
        public void setRasgado(bool Rasgado)
        {
            this.Rasgado = Rasgado;
        }
         public bool getPauta()
        {
            return this.Pauta;
        }
        public void setPauta(bool Pauta)
        {
            this.Pauta = Pauta;
        }
        public void status()
        {
            Console.WriteLine("\n\n*** Caderno. ***");
            Console.WriteLine("\n Marca: " + this.Marca);
            Console.WriteLine("\n TipoCapa: " + this.TipoCapa);
            Console.WriteLine("\n QuantidadeFolha: " + this.QuantidadeFolha);
            Console.WriteLine("\n QuantidadeMateria:" + this.QuantidadeMateria);
            Console.WriteLine("\n Caido: " + this.Caido);
            Console.WriteLine("\n Sujo: " + this.Sujo);
            Console.WriteLine("\n Rasgado: " + this.Rasgado);
            Console.WriteLine("\n Pauta: " + this.Pauta);

        }

        public void caido()
        {
           if(Caido == true)
            {
                Console.WriteLine("\n Então pega.");
            }
            else
            {
                Console.WriteLine("\n Não esta caido.");
            }
        }
        public void Escrever()
        {
            if(Sujo == true)
            {
                Console.WriteLine("\n Caderno  esta sujo.");
            }
            else
            {
                if(Rasgado == true)
                {
                    Console.WriteLine("\n Folha do caderno esta rasgado.");
                }
                else
                {
                    if (Pauta == false)
                    {
                        Console.WriteLine("\n Caderno sem pauta.");
                    }
                    else
                    {
                        Console.WriteLine("\n Começa escrever.");
                    }
                }
                
            }
        }                  

    }
}








