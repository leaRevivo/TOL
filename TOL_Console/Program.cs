using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using TOL_Entitys;

namespace TOL_Console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //string a = Directory.GetCurrentDirectory();




            //var configBuilder = new ConfigurationBuilder()
            //            .SetBasePath(a)
            //            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //           .Build();

            //var _config = configBuilder.GetSection("TOL").Get<>();



            new TOL_Entitys.ServiceDB();
        }
    }
}
