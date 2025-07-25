using System.Threading.Tasks;
using Assignment.InterFaceQ1;
using Assignment.InterFaceQ2;
using Assignment.InterFaceQ3;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //What is the primary purpose of an interface in C#?

            //b) To define a blueprint for a class
            #endregion

            #region Q2
            //Which of the following is NOT a valid access modifier for interface members in C#?

            //a) private
            #endregion

            #region Q3
            //Can an interface contain fields in C#?

            //b) No
            #endregion

            #region Q4
            //In C#, can an interface inherit from another interface? 

            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            //Which keyword is used to implement an interface in a class in C#? 

            //d) implements
            #endregion

            #region Q6
            //Can an interface contain static methods in C#?

            //a)Yes : interfaces can contain static methods in C# 8.0 and later
            #endregion

            #region Q7
            //In C#, can an interface have explicit access modifiers for its members?


            //b) No, all members are implicitly public

            #endregion

            #region Q8
            //What is the purpose of an explicit interface implementation in C#? 

            //a) To hide the interface members from outside access
            #endregion

            #region Q9
            //In C#, can an interface have a constructor? 

            //b) No, interfaces cannot have constructors
            #endregion

            #region Q10
            //How can a C# class implement multiple interfaces?


            //c) By separating interface names with commas
            #endregion

            #region Part02 [Q1]
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

            //{
            //    ICircle circle = new Circle(5);
            //    circle.ShapeInfo();

            //    Console.WriteLine();

            //    IRectangle rectangle = new Rectangle(4, 6);
            //    rectangle.ShapeInfo();
            //}
            #endregion

            #region [Q2]
            //In this example, we start by defining the IAuthenticationService 
            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.Write("Enter username: ");
            //string username = Console.ReadLine();

            //Console.Write("Enter password: ");
            //string password = Console.ReadLine();

            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("Authentication successful!");

            //    Console.Write("Enter role to check: ");
            //    string role = Console.ReadLine();

            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine(" User is authorized.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("User is NOT authorized.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}

            #endregion

            #region [Q3]
            //INotificationService emailService = new EmailNotificationService();// Email
            //emailService.SendNotification("user@example.com", "Welcome to our service!");

            //INotificationService smsService = new SmsNotificationService();// SMS
            //smsService.SendNotification("+20123456789", "Your OTP is 123456");

            
            //INotificationService pushService = new PushNotificationService();// Push
            //pushService.SendNotification("User123", "You have a new message!");
            #endregion

        }
    }
}
