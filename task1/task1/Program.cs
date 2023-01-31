using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        //Verilmis yazinin evvelindeki bosluqlari silib qaytaran metod
        {
            Console.WriteLine(deletethespace("   salam necesen   "));
        }
        static string deletethespace(string name)
        {
            string word ="";
            for(int i=0;i<name.Length;i++)
            {
                if (name[i] != ' ')
                    
                    word += name[i];
            }
            return word;
        }
    }
}
