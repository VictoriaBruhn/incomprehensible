
using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
namespace Home_exercise {  internal class incomprehensible { static void Main(string[] args){ int zebra; Console.WriteLine("Calculator"); Console.WriteLine("Add 2 values together or triple sum if 2 numbers are the same"); bool shouldContinue = true;
            do { Console.WriteLine("Type the first number:"); int fisk = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Type the second number:"); int kartofler = Convert.ToInt32(Console.ReadLine());
                if (fisk == kartofler) { zebra = (fisk + kartofler) * 3; } else { zebra = fisk + kartofler; }
                Console.WriteLine("Result is: " + zebra); Console.ReadKey(); } while (shouldContinue); } } }
