using Demo.InterFace;
using Demo.InterFace_EX02;
using Demo.InterFace_EX03;

namespace Demo
{
    internal class Program
    {
        //static void Print10Number(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}    
        //static void Print10Number(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //} 
        //static void Print10Number(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}


        static void Main(string[] args)
        {
            #region InterFace EX01
            //interFace : Reference Type
            //Code Contract Between The Developer Who Write It And The Developer  Who use it
            //

            //IMyType myType = new IMyType(); // Erorr
            //NOTE : Can't Create Object from Any InterFace 

            //MyType myType = new MyType();
            //myType.salary = 40000;
            //Console.WriteLine(myType.salary);
            //myType.Myfun();


            //IMyType myType;
            //==> ref : Can Refer to Object from any Class Which Implemnted  the InterFace 'myType'

            //myType = new MyType();

            //myType.salary = 10000;
            //Console.WriteLine(myType.salary);
            //myType.Myfun();
            //myType.Print();











            #endregion

            #region Interface EX02
            //SeriesByTwo seriesByTwo = new SeriesByTwo(); // 2
            //Print10Number(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree(); // 3
            //Print10Number(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour(); // 4
            //Print10Number(seriesByFour);


            //Employee[] employees = new Employee [3];
            //{
            //    new Employee() { Id = 10, Name = "Anas", Age = 22, Salary = 12000 };
            //    new Employee() { Id = 20, Name = "Mohamed", Age = 25, Salary = 13000 };
            //    new Employee() { Id = 30, Name = "Madkour", Age = 29, Salary = 19000 };

            //}

            //Array.Sort(employees);
            //foreach (Employee employeee in employees) 
            //{
            //    Console.WriteLine(employeee);
            //}


            #endregion

            #region InterFace EX03
            //Car car = new Car();

            //car.Speed = 100;
            //car.Forward();

            //Airplane airplane = new Airplane();

            //IMoveable moveable = airplane;

            //moveable.Forward();
            //moveable.Right();
            //moveable.Left();
            //moveable.Backward();

            //Console.WriteLine("======================================");

            //IFlyable flyable = airplane;
            //flyable.Forward();
            //flyable.Right();
            //flyable.Left();
            //flyable.Backward();

            #endregion

            #region Shallow Copy & Deep Copy
            //int[] arr01 = { 1, 2, 3, 4, 5 };
            //int[] arr02 = { 6, 7, 8, 9, 10 };

            //Console.WriteLine($"arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 : {arr02.GetHashCode()}");

            ////{ 1, 2, 3, 4, 5 }; ==> Two Ref arr01,arr01
            ////{ 6, 7, 8, 9, 10 }; ==> Unreachable Obeject
            //arr02 = arr01; // Shallow Copy 
            //Console.WriteLine($"arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 : {arr02.GetHashCode()}");

            // IDentity (Address) + Object State [Data]

            //=====================================================================

            //int[] arr01 = { 1, 2, 3, 4, 5 };
            //int[] arr02 = { 6, 7, 8, 9, 10 };

            //Console.WriteLine($"arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 : {arr02.GetHashCode()}");


            //arr02 = (int[]) arr01.Clone(); // Deep Copy // Erorrs ==> Casting 
            //Clone Mathod Will Copy the Object State of Caller
            //Assign the new object arr02 // will Generete New Identity


            //Console.WriteLine($"arr01 : {arr01.GetHashCode()}");
            //Console.WriteLine($"arr02 : {arr02.GetHashCode()}");

            // IDentity (Address) + Object State [Data]

            #endregion

            #region Built-in interFace [icioneable] 

            //Employee E01 = new Employee() {Id = 10 , Name = "Anas" , Age = 22 , Salary = 4000 };
            //Employee E02 = new Employee() {Id = 12 , Name = "Mohamed" , Age = 25 , Salary = 11000 };

            ////E02 = E01; // Shallow Copy

            //E02 = (Employee) E01.Clone(); // Deep Code

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode()); 
            //Console.WriteLine(E01);
            //Console.WriteLine(E02);

            #endregion

            #region Built-in Interface - [ICompareable]

            //Employee[] employees = new Employee[3];
            //{
            //    new Employee() { Id = 10, Name = "Anas", Age = 22, Salary = 12000 };
            //    new Employee() { Id = 20, Name = "Mohamed", Age = 25, Salary = 13000 };
            //    new Employee() { Id = 30, Name = "Madkour", Age = 29, Salary = 19000 };

            //}

            //Array.Sort(employees);

            //int X = employees[1].CompareTo(employees[1]);
            // +ve = Caller Gratear than parameter
            // -ve = Caller less Than parameter
            // 0 = Caller EQual parameter


            //foreach (Employee employeee in employees)
            //{
            //    Console.WriteLine(employeee);
            //}

            //Console.WriteLine(X);
            #endregion

            #region Built-in Interface - [IComparer]
            //Employee[] employees = new Employee[3];
            //{
            //    new Employee() { Id = 10, Name = "Anas", Age = 22, Salary = 12000 };
            //    new Employee() { Id = 20, Name = "Mohamed", Age = 25, Salary = 13000 };
            //    new Employee() { Id = 30, Name = "Madkour", Age = 29, Salary = 19000 };

            //}

            //Array.Sort(employees, new EmployeeComparerSalary());

            //foreach (Employee employeee in employees)
            //{
            //    Console.WriteLine(employeee);
            //}
            #endregion


        }
    }
}
