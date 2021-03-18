using System;

namespace SelectionsTask2
{
    class Program
    {
        static void Main(string[] args)
        {
           string username = "Daniel";
           string password = "Potato";

           Console.WriteLine("Please enter username: ");
           string usernameResult = Console.ReadLine();
           Console.WriteLine("Please enter password: ");
           string passwordResult = Console.ReadLine();

           if (usernameResult == username && passwordResult == password) {
               if (passwordResult == password) {
                   Console.WriteLine("Login successful");
               } else {
                   Console.WriteLine("Login unsuccessful");
               }
           } else {
               Console.WriteLine("Login unsuccessful");
           }

           Console.WriteLine("Please enter a number: ");
            string numOne = Console.ReadLine();
            Console.WriteLine("Please enter another number: ");
            string numTwo = Console.ReadLine();

            int numOneResult = int.Parse(numOne);
            int numTwoResult = int.Parse(numTwo);

            if (numOneResult + numTwoResult > 10) {
                Console.WriteLine("Sum of numbers is greater than 10");
            } else if (numOneResult + numTwoResult == 10) {
                Console.WriteLine("Sum of numbers is equal to 10");
            } else {
                Console.WriteLine("Sum of numbers is less than 10");
            }
        }
    }
}
