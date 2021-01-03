using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TOL_Entitys
{
    public class ServiceDB
    {
        public MongoClient Client { get; set; }

        public MongoDatabaseBase Database { get; set; }
        public ServiceDB()
        {
            Client = new MongoClient(ManagerSetting.Instance.Settings.ConnectionString);

            Database = Client.GetDatabase(ManagerSetting.Instance.Settings.DatabaseName);

        }


        public bool Insert(BaseDocument base)
        {

        }
    }
}