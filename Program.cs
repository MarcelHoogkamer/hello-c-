using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Today it's " + DateTime.Now.ToString() + "May I ask for your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + " nice to meet you. Are you male or female?");
            string gender = Console.ReadLine();

            if (gender == "Male")
            {
                Console.WriteLine("You've got some balls man, being " + gender);
            }
            else
            {
                Console.WriteLine("Nice tits, the perks of being " + gender);
            }

            Console.WriteLine("Nice to see that you are a " + gender);
            Console.WriteLine("What is your age?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            if(age == 36)
            {
                Console.WriteLine("You are " + age + " years old");
            } else
            {
                Console.WriteLine("Try again buddy");
            }

           
        }
    }
}
