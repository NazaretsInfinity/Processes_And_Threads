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
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Result: {int.Parse(args[0]) + int.Parse(args[2])}");
            }
            catch (Exception e)
            {
                Console.WriteLine("you input something but not instance, it seems.", "error", 1);
                Console.WriteLine(e.Message);
            }
            Console.ReadLine(); // just to no let it exit instantly
        }
    }
}
