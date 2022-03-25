using System;

namespace PrimeNumbers
{
    class Program
    {


        //Klavyeden girilen sayının asal olup olmadığını bulan program.
        public static void primeNumValue()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()); //Kullanıcıdan bir sayı alınıyor.
            bool status = false;
            for (int x = 2; x <= number / 2; x++)//Aldığımız sayı asal mı degil mi bulmak için bir döngü tanımlıyoruz ve o sayının yarısı kadar döngü dönüyor.
            {
                if (number % x == 0)//aldıgımız sayının asal olup olmadıgını anlamak için bu sayının yarısına kadar olan sayıları tek tek alıp, bölünüp bölünmediğine bakıyoruz.
                {
                    status = true; // Eğer bölünüyorsa sayı asal degildir o yüzden status true yapıp break ile döngüyü sonlandırıyoruz.
                    break;
                }
            }
            if (status == false)// status false ise ekrana asal oldugunu yazdırıyoruz. 
            {
                Console.WriteLine(number+" is prime.");
            }
            else// status true ise ekrana asal olmadıgını yazdırıyoruz. 
            {
                Console.WriteLine(number + " isn't prime.");
            }

        }







            // 1 ile 10.000 arasındaki asal sayıları ekrana yazdıran program.
            public static void primeNum()
            {
            bool status = false;
            for (int i = 2; i <= 10000; i++) //2-10bin arasındaki sayıları sırayla alıyoruz.
            {
                status = false;
                for (int x = 2; x <= i / 2; x++)//Aldığımız sayı asal mı degil mi bulmak için yine bir döngü tanımlıyoruz ve o sayının yarısı kadar döngü dönüyor.
                {
                    if (i % x == 0)//ilk döngüde aldıgımız sayının asal olup olmadıgını anlamak için bu sayının yarısına kadar olan sayıları tek tek alıp bölünüp bölünmediğine bakıyoruz.
                    {
                        status = true; // eğer Eğer bölünüyorsa sayı asal degildir o yüzden status true yapıp break ile döngüyü sonlandırıyoruz
                        break;
                    }
                }
                if (status == false)// status false ise ekrana yazdırıyoruz yani sayı asal demektir. 
                {
                    Console.WriteLine(i);
                }

            }



        }
        static void Main(string[] args)
        {
            primeNum();
            primeNumValue();
        }
    }
}
