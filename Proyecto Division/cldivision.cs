using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Division
{
    internal class cldivision
    {
        private double n1;
        private double n2;

        public cldivision(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

       
        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }

        public double DVSN()
        {
            return n1 / n2;
        }

        public cldivision()
        {

        }

    }

}
