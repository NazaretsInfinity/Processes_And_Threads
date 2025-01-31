using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW2_ChildProccess
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
#if true1 // for calculating(task 3)
            try { Console.WriteLine($"Result: {int.Parse(args[0]) + int.Parse(args[2])}"); } // only addition,tho...
            catch (Exception e)
            {
                Console.WriteLine("you input something but not instance, it seems.", "error", 1); 
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
#endif

            try // because we don't know what you can enter...
            {
                StreamReader reader = new StreamReader(args[0]);
                string[] chto = { $"{args[1]}" }; //idk I didn't find Split(0 that wuld take simple string
                Console.WriteLine($"Quanity of word : {reader.ReadToEnd().Split(chto, 0).Length - 1}");
                reader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("error in given arguments", "error", 1);
            }
            Console.ReadLine(); // just to no let it exit instantly
        }
    }
}
