namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and displaying their shape information.
            //ICircle circle = new Circle(2);
            //circle.DisplayShapeInfo();
            //IRectangle rectangle = new Rectangle(2,3);
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question 2
            //IAuthenticationService authServiceUser = new BasicAuthenticationService();
            //if (authServiceUser.AuthenticateUser("UserRawan","Rawan"))
            //{
            //    Console.WriteLine("AuthenticateUser is succeeded");
            //}
            //else
            //{
            //    Console.WriteLine("AuthenticateUser is failed");

            //}
            //if (authServiceUser.AuthorizeUser("UserRawan", "Admin"))
            //{
            //    Console.WriteLine("AuthorizeUser is succeeded");
            //}
            //else
            //{
            //    Console.WriteLine("AuthorizeUser is failed");

            //}

            #endregion

            #region Question 3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();
            emailService.SendNotification("Rawan@gamil.com", "hello");
            smsService.SendNotification("Rawan", "hello");
            pushService.SendNotification("Message", "hello");
            #endregion
        }
    }
}
