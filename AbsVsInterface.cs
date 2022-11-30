using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface IDal
    {
        void addI();
        internal void add();
        abstract void update();
    }
    abstract class ADal
    {
        public void add() {

          
        }
        public abstract void update();
    }

    class Cust : ADal, IDal
    {
        void IDal.add()
        {
            throw new NotImplementedException();
        }

        public void addI()
        {
            throw new NotImplementedException();
        }

        public override void update()
        {
            throw new NotImplementedException();
        }
    }
}
