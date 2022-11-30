using OOPS;
using System;
using OOPS_INTERNAL;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of the class Student
            Student S = new Student(1, "Astrid");

            // Displaying details directly
            // using the class members
            // accessible through another method
            Console.WriteLine("Roll number: {0}", S.rollNo);
            Console.WriteLine("Name: {0}", S.name);

            Console.WriteLine();

            // Displaying details using
            // member method also public
            Console.WriteLine("Roll number: {0}", S.getRollNo());
            Console.WriteLine("Name: {0}", S.getName());



            Console.WriteLine("---protected start ----");

            //protected block
            protectedX obj1 = new protectedX();
            Inherit_protectedX_Y obj2 = new Inherit_protectedX_Y();

            // Displaying the value of x
            //The code is accessible in a class that is inherited from that class like i can access X
            Console.WriteLine("Value of x(protected) is : {0}", obj2.getX());
            //The code is accessible within the same class like i can't access X
            Console.WriteLine("Value of y(public) is : {0}", obj1.y);

            Console.WriteLine("--- protected end ----");


            Console.WriteLine("--- internal start ----");

            // Instantiate the class Complex
            // in separate class but within
            // the same assembly
            PublicComplex c = new PublicComplex();

            // Accessible in class Program
            c.setDataPublic(2, 1);

            //can't access protected internal due to protection level
            //c.displayDataPublic();


            Console.WriteLine("--- internal end ----");


            Parent obj1Parent = new Parent();
            obj1Parent.protected_internal_value = 12;


            Console.WriteLine("--- ExtensionM start ----");

            string word = "I am Satish Rathore";
            word.WordCount();

            Console.WriteLine("Total number of words in :" + word + ": is " + word.WordCount());

            Console.WriteLine("--- ExtensionM end ----");

            try
            {
                Program p = new Program();
                p.AnotherMethod();
            }
            catch (Exception ex)
            {
                throw;
            }

            Console.ReadLine();
        }

        public void ExceptionMethod()
        {
            throw new Exception("Original Exception occurred in ExceptionMethod");
        }

        public void AnotherMethod()
        {
            Program p = new Program();
            try
            {
                p.ExceptionMethod();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

    #region public
    class Student
    {

        // Declaring members rollNo
        // and name as public
        public int rollNo;
        public string name;

        // Constructor
        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        // methods getRollNo and getName
        // also declared as public
        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }

    #endregion

    #region protected
    class protectedX
    {

        // Member x declared
        // as protected
        protected int x;
        public string y;

        public protectedX()
        {
            x = 10;
            y = "I am public";
        }
    }

    // class Y inherits the
    // class X
    class Inherit_protectedX_Y : protectedX
    {

        // Members of Y can access 'x'
        public int getX()
        {
            return x;
        }
    }

    #endregion

    #region protected internal

    public class Parent
    {

        // Declaring member as protected internal
        protected internal int protected_internal_value;
        protected private int private_protected_value;

    }

    public class Child : PublicComplex
    {
        // Accessing value in another assembly
        Child obj3 = new Child();
        public void Main()
        {
            Child obj3 = new Child();
            obj3.displayDataPublic();
            //obj3.displayData_Potected_Private(); // can't acess due to other assembly.
        }
    }

    #endregion

    #region protected private
    public class PrivateChild : Parent
    {
        // Accessing value in another assembly
        PrivateChild _privateChild = new PrivateChild();
        public void Main()
        {
            _privateChild.private_protected_value = 1;
            //obj3.displayData_Potected_Private(); // can't acess due to other assembly.
        }
    }
    #endregion


    
}
