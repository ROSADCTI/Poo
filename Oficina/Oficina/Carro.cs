using System;
using System.IO.IsolatedStorage;
using System.Security.Cryptography.X509Certificates;

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



        public string sistuacaoMotor()
        {
            if (this.motorligado )
            {
                return  " * Motor do " + this.modelo + " -->  motor ligado.";
            }
            else
            {
                return " * Motor do " + this.modelo + " -->   motor desligado.";
            }
            
        }
         public string ligarMotor()
         {
            if (this.motorligado)
            {
                return "\n * Motor do " + this.modelo + " -->  já estava ligado.";
                
            }
            else
            {
                return "\n * Motor do " + this.modelo + "  -->  foi ligado.";
            }
         }
        public string DesligarMotor()
        // se motor do carro estive Desligado (falser)
        {
            if (this.motorligado)
            {
                return "\n * Motor do " + this.modelo + "  --> já estava desligado.\n";
            }
            // verificando velocidade   se carro é Zero
             if (this.velocidade == 0)
            {
                // motor desligado
                this.motorligado = false;
                return "\n * O motor do " + this.modelo + "  --> foi desligado.";
            }
            else
            {
                return "\n * O motor do " + this.modelo + "  --> Não foi desligado, pois o carro esta em movimento.";
            }

        }
        public string acelerar(int valor)
        {
            if (this.motorligado)
            {
                this.velocidade = this.velocidade + valor;
                return "  \n * " + this.modelo + " -->  Acelerou velocidade atual:" + this.velocidade + " km/h. \n";
            }
            else
            {
                return " \n  * " + this.modelo + " --> Não é possivel aceleral com motor desligado: ";
            }

        }
        public string frear(int valor)
        {      // se motor esta desligado(false)
            if (!this.motorligado)
            {
                return " \n * " + this.modelo + " --> O motor do carro está desligador! o carro está parado!";
            }            // Garantido se motor está ligado
                       // verifacar se velocidade é ZERO
            
            if(this.velocidade == 0)
            {
                return " \n * " + this.modelo + " --> O carro já esta parado! \n\n\n";
            }         
                         // Agora ver se motor está LIGADO e a velocida é DIFERENTE DE ZERO.
                      //  Redução de velocidade daria o valor negativo.
             if((this.velocidade - valor ) < 0)
            {
                this.velocidade = 0;
                return "\n * " + this.modelo + " --> Freio!!! o carro está parado.";
            }
            else
                     ///Aplicado o decréscimento da velocida.
            {
                this.velocidade -= valor;  
                return " \n * " + this.modelo + " --> Freio!!!  velocidade atual: " + this.velocidade + " Km/h.";
            }
                
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



    
 

 
 
 