using System.Text.RegularExpressions;
using System.Text;

namespace Pärilusauto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var masin = new Machine();
            Console.Write("Sisestage masina number: ");
            string masinaNumber = Console.ReadLine();

            masin.Pärilus(masinaNumber);
        }
        public class Cars
        {
            public string vin { get; set; }
        }
        public class Machine : Cars
        {
            public void Pärilus(string masinaNumber)
            {
                string vin = GenerateVinCode(masinaNumber);

                Console.WriteLine("VIN-kood on {0}", vin);
            }

            private string GenerateVinCode(string masinaNumber)
            {
                throw new NotImplementedException();
            }
        }
    }
}
