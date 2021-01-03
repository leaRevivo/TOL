using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;
namespace TOL_Entitys
{
    public interface IAppSettings
    {
       
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
  
    public    class AppSettings : IAppSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }


    public class ManagerSetting
    {

        private static readonly Lazy<ManagerSetting> _instance = new Lazy<ManagerSetting>(() => new ManagerSetting());
        public static ManagerSetting Instance
        {
            get
            {
                return _instance.Value;
            }
        }


        public  AppSettings Settings;

        private ManagerSetting()
        {
       
            var configBuilder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                       .Build();

            Settings = configBuilder.GetSection("TOL").Get<AppSettings >();
         
        }




    }
}

