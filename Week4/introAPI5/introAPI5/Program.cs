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
        * .NET CORE sadece windows iþletim sisteminde kullanýlmýyor linux ya da mac in iþletim sisteminde de
        * kullanýlabiliyor. Platform bagýmsýz bir dildir.
        * 
        * API - Application Programming Interface
        * web api : http protokoli ile eriþecegimiz fonksiyonlardan ibarettir.
        * 
        * 
        * Neden API ? çünkü ortak bir bilgiye dayalý uygulamalar geliþtirmek istiyorsak.
        * http üzerinde request gönderip ihtiyac duydugumuz veri üzerinde calýþmayý saglýyor.


        */
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); //
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // uygulamamýzda kullanmak istedigimiz dosyalar startup da bulunuyor
                });
    }
}
