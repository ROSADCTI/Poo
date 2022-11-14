using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oficina
{
    public class Pneu
    {
        private string marca;
        private int    aro;
        private bool   furado;
        private int    psi;
        private bool   estourado;
        private double percentualBorracha;
        private int    rotacao;


        public string getmarca()
        {
            return this.marca;
        }
        public void setmarca(string marca)
        {
            this.marca = marca;
        }
        public int getaro()
        {
            return this.aro;
        }
        public void setaro(int aro)
        {
            this.aro = aro;
        }
        public bool getfurado()
        {
            return this.furado;
        }
        public void setfurado(bool furado)
        {
            this.furado = furado;
        }
        public int getpsi()
        {
            return this.psi;
        }
        public void setpsi(int psi)
        {
            this.psi = psi;
        }
        public bool getestourado()
        {
            return this.estourado;
        }
        public void setestourado(bool estourado)
        {
            this.estourado = estourado;
        }
        public double getpercentualBorracha()
        {
            return this.percentualBorracha;
        }
        public void setpercentualBorracha(double percentualBorracha)
        {
            this.percentualBorracha = percentualBorracha;
        }
        public int getrotacao()
        {
            return this.rotacao;    
        }
        public void serotacao(int rotacao)
        {
            this.rotacao = rotacao; 
        }

        public Pneu(int aro,string marca)
        {
            this.marca = marca;
            this.aro = aro;
            this.furado = false;
            this.psi = 33;
            this.estourado = false;
            this.percentualBorracha = 100;
            this.rotacao = 0;
        }
        public void girar(int _rotacao)
        {
            
           rotacao += _rotacao;
           gastarBorracha(_rotacao / 100.0);
        }
        
        public void furar()
        {
            furado = true;
            psi = 0;
        }
        private void gastarBorracha(double _quantidade)
        {
            percentualBorracha -= _quantidade;
                if (percentualBorracha == 0)
                estourar();
        }
        private void estourar()
        {
            estourado = true;
            psi = 0;
            percentualBorracha = 0;
            rotacao = 0;      
        }
        public void freiar(int _abatimento)
        {
            rotacao -= _abatimento;
            gastarBorracha(_abatimento / 100);
            if(rotacao == 0)
            {
                rotacao = 0;
            }
        }
        public void remendar()
        {
            furado = false;
             psi = 33;
        }
        public void exibir()
        {
            Console.WriteLine(" \n ****** Pneu *****");
            Console.WriteLine(" \n marca :" + this.marca);
            Console.WriteLine(" \n aro: " + this.aro);
            Console.WriteLine(" \n furado: " + this.furado);
            Console.WriteLine(" \n psi: " + this.psi);
            Console.WriteLine(" \n estourado: " + this.estourado);
            Console.WriteLine(" \n percentualBorracha: " + this.percentualBorracha);
            Console.WriteLine(" \n rotaca: "+ this.rotacao);

        }
    }
        
}

