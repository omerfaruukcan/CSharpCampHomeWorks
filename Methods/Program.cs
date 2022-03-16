using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var toplam = Add2(5, 7);
            Console.WriteLine(toplam);
            Add3(5); // ikinci parametreyi vermedik cunku default olarak 30 tanimladik

            Console.WriteLine("----------------------------- ");

            int n1 = 20;
            int n2 = 100;
            var toplam2 = Add4(n1, n2);
            Console.WriteLine(toplam2);
            Console.WriteLine(n1); // n1 yine 20 olacak cunku method icinde degismesi kendi degerini degistirmez

            Console.WriteLine("----------------------------- ");

            int n3 = 20;
            int n4 = 100;
            var toplam3 = Add5(ref n3, n4);
            Console.WriteLine(toplam3);
            Console.WriteLine(n3); // n3 bu sefer 30 oldu cunku referans olarak aldik.

            Console.WriteLine("----------------------------- ");

            int n5;
            int n6 = 100;
            var toplam4 = Add6(out n5, n6); // out kullandigimizdan dolayi n5 değişkenine veri girmemize gerek yoktur.
            Console.WriteLine(toplam4);
            Console.WriteLine(n5);

            Console.WriteLine("----------------------------- ");

            Console.WriteLine(Add7(2, 5, 7, 3, 15)); // burda ilk degeri n1 olarak alir ve digerlerini paramsin icine koyar

            Console.WriteLine("----------------------------- ");

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2) // static int dedik cunku sonucu bir int deger olarak dondurduk. 
        {
            var result = number1 + number2;
            return result;
        }

        static void Add3(int number1, int number2 = 30)
        {
            int result = number1 + number2;
            Console.WriteLine(result);
        }

        static int Add4(int n1, int n2)
        {
            n1 = 30;
            return n1 + n2;
        }

        static int Add5(ref int n1, int n2)
        {
            n1 = 30;
            return n1 + n2;
        }

        static int Add6(out int n1, int n2)
        {
            n1 = 30; // out kullanilacaksa burda mutlaka deger set edilmelidir
            return n1 + n2;
        }

        static int Add7(int n1, params int[] numbers)
        {
            return n1 + numbers.Sum();
        }

        static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        static int Multiply(int n1, int n2, int n3) // parametre sayisi farklı oldugundan ayni metot ismi kabul edildi
        {
            return n1 * n2 * n3;
        }


    }
}