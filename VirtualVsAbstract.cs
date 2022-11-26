using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    /* Abstract Method:

        If an abstract method is defined in a class, then the class should declare as an abstract class.
        An abstract method should contain only method definition, should not Contain the method body/implementation.
        An abstract method must be over ride in the derived class.


        Virtual Method:

        Virtual methods can be over ride in the derived class but not mandatory.
        Virtual methods must have the method body/implementation along with the definition.
     */
    internal class VirtualBaseClass
    {
        //Virtual methods must have the method body/implementation along with the definition.
        internal virtual int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
    internal class VirtualChildClass : VirtualBaseClass
    {
        //Virtual methods can be over ride in the derived class but not mandatory.

        //internal override int Add(int num1, int num2)
        //{
        //    if (num1 == num2)
        //    {
        //        return (num1 + num2);
        //    }

        //    return 0;
        //}

        public int AddWithoutAbstract(int num1, int num2)
        {
            //you cant create an instance of an abstract class.
            //EntityBase entityBase = new EntityBase();

            return (num1 + num2);
        }

    }

    public abstract class EntityBase
    {
        public abstract int Add(int num1, int num2);
        public int AddWithoutAbstract(int num1, int num2)
        {
            // you cant create an instance of an virtual class.
            VirtualBaseClass virtualBaseClass = new VirtualBaseClass();
            virtualBaseClass.Add(5, 3);

            return (num1 + num2);            
        }
       
    }

    public class Customer : EntityBase
    {
        //Implementation code for the abstract methods
        public override int Add(int num1, int num2)
        {
            if (num1 == num2)
            {
                return (num1 + num2);
            }

            return 0;
        }
    }
}
