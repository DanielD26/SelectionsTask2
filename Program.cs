using System;

namespace SelectionsTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = {"Daniel, Naruto"};
            string[] password = {"Potato, Ramen"};

            Console.WriteLine("Please enter username: ");
            string usernameResult = Console.ReadLine();

            string userDaniel = "Daniel";
            string DanielResult = Array.Find(username, element => element == userDaniel); 
            
            if (usernameResult == DanielResult) {
                Console.WriteLine("User exists");
            } else {
                Console.WriteLine("User doesn't exist");
            }
        }
    }
}
