using System;

namespace Get_Description_From_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String Address;
            int age;
            int contact;

            Console.Write("please enter your name: ");
            name = Console.ReadLine();
            Console.Write("please enter your address: ");
            Address = Console.ReadLine();
            Console.Write("please enter your age: ");
            //age = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter your contact: ");
            contact = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The name is {0}.", name);
            Console.WriteLine("The address is {0}.", Address);
            Console.WriteLine("the age is {0}.", age);
            Console.WriteLine("the contact is {0}.", contact);
            Console.ReadLine();
        }
    }
}
