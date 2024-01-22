using System;
{ 
namespace Assignment1Exercise1
{





    class Program
    {





        static void Main(string[] args)
        {




           
            Console.Write("Enter an integeger:");
            { 
            string input = Console.ReadLine();
            int num1 = int.Parse(input);
            Console.WriteLine("After using int.parse:" + num1);
            




            Console.Write("Enter an integer again:");
            string input1 = Console.ReadLine();
            int num2 = Convert.ToInt32(input1);
            Console.WriteLine("After using Convert.ToInt :" + num2);

            Console.Write("Enter an integer again:");
            string input3 = Console.ReadLine();
            int num3;
            if (int.TryParse(input3, out num3))
            {
                Console.WriteLine(" After using int.TryParse:" + num3);
            }
            else
            {
                Console.WriteLine("Invalid input.Please enter an integer");
            }
            
            Console.Write("Enter a Float value:");
            string input4 = Console.ReadLine         ();
            float num4 = float.Parse(input4);
            Console.WriteLine("After using float.parse:" + num4);
            
            Console.Write("Enter a Float value again:");
            string input5 = Console.ReadLine();
            float num5 = Convert.ToSingle(input5);
            Console.WriteLine("After using Convert.ToSingle:" + num5);

            Console.Write("Enter a float value again:");
            string input6 = Console.ReadLine();
            float num6;
            if (float.TryParse(input6, out num6))
            {
                Console.WriteLine("After using float.TryParse:" + num6);
            }
            else
            {
                Console.WriteLine("Invalid input.Please enter a float value");
            }
          
            Console.Write("Enter a boolean value:");

            string boolInput1 = Console.ReadLine();

            try
            {
                bool boolVal = bool.Parse(boolInput1);
                Console.WriteLine("After using bool.Parse:" + boolVal);
            }
            catch (FormatException e)
            {
                Console.WriteLine("invalid input" + e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("invalid input" + e.Message);
            }
            
            Console.Write("Enter a Boolean value:");
            string boolInput2 = Console.ReadLine();

            try
            {
                bool boolVal2 = Convert.ToBoolean(boolInput2);
                Console.WriteLine("After using Convert.ToBoolean: " + boolVal2);
            }
            catch (FormatException e)
            {
                Console.WriteLine("invalid input" + e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("invalid input" + e.Message);
            }
            Console.Write("Enter a boolean(true or false):");
            string boolInput3 = Console.ReadLine();
            bool boolVal3;
            if (bool.TryParse(boolInput3, out boolVal3))
            {
                Console.WriteLine("After using bool.TryParse :" + boolVal3);
            }
            else
            {
                Console.WriteLine("Invalid input.Please enter a boolean(true or false)");
            }
           Console.ReadLine();
        }
    }
}
