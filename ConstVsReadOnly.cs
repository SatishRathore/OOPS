using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    /*
     * ReadOnly Keyword

            In C#, readonly fields can be created using readonly keyword
            ReadOnly is a runtime constant.
            The value of readonly field can be changed.
            It cannot be declared inside the method.
            In readonly fields, we can assign values in declaration and in the constructor part.
            It can be used with static modifiers.

     * 
     * Const Keyword

        In C#, constant fields are created using const keyword.
        Const is a compile time constant.
        The value of the const field can not be changed.
        It can be declared inside the method.
        In const fields, we can only assign values in declaration part.
        It cannot be used with static modifiers.

     * 
     * 
     * 
     */
    public class ConstVsReadOnly
    {
        public readonly int rd_count;
        public const int const_count = 0;
        //public const fields that are shared across assemblies
        public ConstVsReadOnly()
        {
            //In readonly fields, we can assign values in declaration and in the constructor part
            rd_count = 100;
            //const_count = 2000;
        }

        public void Readonly_Iinside_Method()
        {
            //cant declare inside method
            //private readonly int count;
            //rd_count = 10;
        }

        public void Const_Inside_Method()
        {
            const int const_count_inside = 0;
            //cant declare inside method
            //const_count = 10;
        }
    }

    public class UseConstReadonly
    {
        public void useconst()
        {
            ConstVsReadOnly cr = new ConstVsReadOnly();            
        }
    }

}


