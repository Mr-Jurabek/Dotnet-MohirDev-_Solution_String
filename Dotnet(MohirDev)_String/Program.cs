using System.Diagnostics;

namespace Dotnet_MohirDev__String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MohirDev platformasidan xarid qilingan Dotnet onlayn kurs vazifalarim
            //String kirish qismiga oid topshiriq yechimi
            string ism;
            int yosh;

            Console.WriteLine("Assalomu alaykum!\nIltimos ismingizni kiriting!");
            ism = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Iltimos, yoshingizni kiriting!");
            yosh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{ism} sizning yoshingiz {yosh} da ekan!");

            Console.ReadKey();


        }
    }
}