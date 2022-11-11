using System;
namespace Oficina
{
    public class Carro
    {
        private string fabricante;
        private string modelo;
        private int ano;
        private bool motorligado;
        private int velocidade;
        private string cor;

        public String sistuacaoMotor()
        {
            if (motorligado)
            {
                return this.modelo + " --> motor ligado.";
            }
            else
            {
                return this.modelo + " --> motor desligado.";
            }
            
        }
        public Carro(string fabricante, string modelo, int ano, bool motorLigado, int velocidade, string cor)
        {
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.ano = ano;
            this.motorligado = motorLigado;
            this.velocidade = velocidade;
            this.cor = cor;
        }
        public string getfabricante()
        {
            return this.fabricante;
        }
        public void setfabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }
        public string getmodelo()
        {
            return this.modelo;
        }
        public void setmodelo(string modelo)
        {
            this.modelo = modelo;
        }
        public int getano()
        {
            return this.ano;
        }
        public void setano(int ano)
        {
            this.ano = ano;
        }
        public bool getmotorligado()
        {
            return this.motorligado;
        }
        public void setmotorLigado(bool motorLigado)
        {
            this.motorligado = motorLigado;
        }
        public int getvelocidade()
        {
            return this.velocidade;
        }
        public void setvelocidade(int velocidade)
        {
            this.velocidade = velocidade;
        }
        public string getcor()
        {
            return this.cor;
        }
        public void setcor(string cor)
        {
            this.cor = cor;
        }

        public void status()
        {
            Console.WriteLine(" \n **** CARRO ***** ");   
            Console.WriteLine("\n fabricante " + this.cor);
            Console.WriteLine("\n modelo: " + this.modelo);
            Console.WriteLine("\n ano; " + this.ano);
            Console.WriteLine("\n motorligado: " + motorligado);
            Console.WriteLine("\n velocidade: " + velocidade + "Km");
            Console.WriteLine("\n cor: " + this.cor  + "\n ");
        }




 }  }



    
 

 
 
 