using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constructors 
            ////Employee Emp1 = new Employee();
            //Employee Emp2 = new Employee(2,"ALi",4000,"Alex");
            //Employee Emp3 = new Employee(2,null,1000,"Alex");
            //Employee Emp4 = new Employee("Ahmed", "Cairo");
            //Employee Emp5 = new Employee("Ahmed", 6000);

            //// Employee Emp6 = new Employee(Emp2.ID, Emp2.Name,Emp2.Salary,Emp2.Address);
            //Employee Emp6 = new Employee(Emp2);



            ////Emp1.Display();
            //Emp2.Display();
            //Emp3.Display(); 
            #endregion

            #region Static Keyword 
            //Employee.DeptName = "OS"; //will call static constructor

            //Employee Emp1 = new Employee("Ali","Minia");
            //Emp1.Display();

            //Employee Emp2 = new Employee("Ahmed", "Alex");
            //Emp2.Display();

            //Employee Emp3 = new Employee("Asmaa", "Alex");
            //Emp3.Display();


            //Employee.Show();

            ////Emp1.DeptName = "OS"; //Error, must be called by class name only
            //Employee.DeptName = "OS"; // will affect all objects
            //Emp1.Display();
            //Emp2.Display();


            #endregion

            #region this Keyword
            //Employee Emp1 = new Employee("ALi");
            //Employee Emp2 = new Employee("Ahmed","Alex");

            //Emp1.Display(); //===> in compiler==> Display(this) ==> this=caller =Emp1
            //Emp2.Display();//===> in compiler==> Display(this) ==> this=Caller= Emp2 
            #endregion

            #region Encapsulation
            // //Car C1 = new Car(4000);
            //// C1.Price = 2000; //Error
            //Car C1 = new Car();
            // //C1.SetPrice(3000);
            // //Console.WriteLine(C1.GetPrice());

            // //using Proprty 
            // C1.Price = 6000; // set

            // Console.WriteLine(C1.Price); //get

            // C1.Move();

            #endregion



            Console.ReadKey();
        }

        /* Lec Summary :
         *  ===> Types of Constructors 
         *      ===> Default 
         *      ===> Parametrized
         *      ===> Copy
         *      ===> Static
         *      ===> private
         *  ===> this 
         *  ===> constructor Chaining 
         *  ===> Static Keyword
         *  ===> Encapsulation 
         *          ===> Access Modifiers 
         *          ===> Proprties
         * Next Lec:
         *      ===> Destructor
         *      ===> Oprator Overloading 
         *      ===> Relation between classes 
         *          ===> Compsition
         *          ===> Aggeregation
         *          ===> Association
         *          ===> Inheritance
         * */     
    }
}
