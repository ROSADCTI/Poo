using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina
{
    public class Pneu
    {
        private string marca;
        private int aro;
        private bool furado;
        private int psi;
        private bool estourado;
        private double percentualBorracha;
        private int rotacao;


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

        public Pneus(int aro, string marca)
        {
            aro = aro;
            marca = marca;
            furado = false;
            psi = 33;
            estourado = false;  

        }
    }
}
