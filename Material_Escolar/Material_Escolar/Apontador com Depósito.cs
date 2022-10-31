using System;
using System.Security.Cryptography.X509Certificates;

namespace Material_Escolar
{
    public class Apontador_com_Depósito
    {
        private int    Altura;
        private int    Largura;
        private int    Comprimento;
        private string Cor;
        private string Marca;
        private string Embalagem;
        private string Formato;
        private bool LaminaCega;
        private bool   Quebra;

     public Apontador_com_Depósito(int altura,int largura,int comprimento,string cor,string marca,string embalagem,string formato,bool lamina,bool quebra)
        {
          this.Altura = altura;
          this.Largura = largura; 
          this.Comprimento = comprimento;     
          this.Cor = cor;
          this.Marca = marca;
          this.Embalagem = embalagem;
          this.Formato = formato;
          this.LaminaCega = lamina;
          this.Quebra = quebra;
            
        }
        public int getAltura()
        {
            return this.Altura;
        }
        public void setAltura(int Altura)
        {
            this.Altura = Altura;
        }
        public int getLargura()
        {
            return this.Largura;    
        }
        public void setLargura(int Largura)
        {
            this.Largura = Largura; 
        }
        public int getComprimento()
        {
            return this.Comprimento;    
        }
        public void setComprimento(int Comprimento)
        {
            this.Comprimento = Comprimento; 
        }
        public string getCor()
        {
            return this.Cor;    
        }
        public void setCor(string Cor)
        {
            this.Cor = Cor; 
        }
        public string getMarca()
        {
            return this.Marca;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public string getEmbalagem()
        {
            return this.Embalagem;
        }
        public void setEmbalagem(string Embalagem)
        {
            this.Embalagem = Embalagem; 
        }
        public string getFormato()
        {
            return this.Formato;
        }
        public void setFormato(string Formato)
        {
            this.Formato = Formato;
        }
        public bool getLaminaCega()
        {
            return this.LaminaCega;
        }
        public void setLaminaCega(bool LaminaCega)
        {
            this.LaminaCega = LaminaCega;
        }
        public bool getQuebra()
        {
            return this.Quebra; 
        }
        public void setQuebra(bool Quebra)
        {
            this.Quebra = Quebra;
        }
        public void status()
        {
            Console.WriteLine("\n ** Apontado com Depósito. **");
            Console.WriteLine("\n Altura: " + Altura + "mm");
            Console.WriteLine("\n Largura: " + Largura +"mm" );
            Console.WriteLine("\n Comprimento: " + Comprimento + "mm");
            Console.WriteLine("\n Cor:" + Cor);
            Console.WriteLine("\n Marca:" + Marca);
            Console.WriteLine("\n Embalagem:" + Embalagem);
            Console.WriteLine("\n Formato:" + Formato);
            Console.WriteLine("\n LaminaCega:" + LaminaCega);
            Console.WriteLine("\n Quebra: " + Quebra);
        }
        public void Quebrado()
        {
            if (Quebra == true)
            {
                Console.WriteLine("\n O apontador não esta quebrado.");
            }
            else
            {
                Console.WriteLine("\n Apontador esta quebrado.");
            }    
        }
        public void laminacega()
        {
           if(LaminaCega == true)
            {
                Console.WriteLine("\n Lâmina não esta ceda, pode apontada o lápis.");
            }
            else
            {
                if (LaminaCega == false)
                {
                    Console.WriteLine("\n O lápis pode ser apontado.");
                }
            }
        }
        public void aponta()
        {
            if(Quebra == true)
            {
                Console.WriteLine("\n Troque o apantador.");
            }
            else
            {
                if(LaminaCega == true)
                {
                    Console.WriteLine("\n troque o refil lâmina.");   
                }
            }
        }

    }
}


