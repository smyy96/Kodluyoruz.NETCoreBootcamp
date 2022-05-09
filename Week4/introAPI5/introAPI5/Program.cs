using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI5
{
    public class Program
    {
        /*
        * .NET CORE sadece windows i�letim sisteminde kullan�lm�yor linux ya da mac in i�letim sisteminde de
        * kullan�labiliyor. Platform bag�ms�z bir dildir.
        * 
        * API - Application Programming Interface
        * web api : http protokoli ile eri�ecegimiz fonksiyonlardan ibarettir.
        * 
        * 
        * Neden API ? ��nk� ortak bir bilgiye dayal� uygulamalar geli�tirmek istiyorsak.
        * http �zerinde request g�nderip ihtiyac duydugumuz veri �zerinde cal��may� sagl�yor.


        */
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); //
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // uygulamam�zda kullanmak istedigimiz dosyalar startup da bulunuyor
                });
    }
}
