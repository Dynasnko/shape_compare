using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public class TrapeZoid : Shape
    {
        private double _TopHigh;
        private double _DownHigh;
        private double _TrapeZoidHigh;


        public double TopHigh
        {
            get { return _TopHigh; }
            set { _TopHigh = value; }
        }
        public double DownHigh
        {
            get { return _DownHigh; }
            set { _DownHigh = value; }
        }
        public double TrapeZoidHigh
        {
            get { return _TrapeZoidHigh; }
            set { _TrapeZoidHigh = value; }
        }

        public TrapeZoid(double User_TopHigh,double User_DownHigh,double User_TrapeZoidHigh) { 
           this.TopHigh= User_TopHigh;
            this.DownHigh= User_DownHigh;
            this.TrapeZoidHigh= User_TrapeZoidHigh;
            CountArea();
        }

        public override void CountArea()
        {
            this.area = (this.TopHigh + this.DownHigh )*this.TrapeZoidHigh/2 ; 
        }
    }
}
