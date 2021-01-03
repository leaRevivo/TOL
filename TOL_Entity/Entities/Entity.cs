using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TOL_Entitys
{
   public abstract BaseDocument
    {
        public string NameCollection { get; set; }
    }

    public  class Company:BaseDocument
    {
    public Company()
    {
        base.NameCollection="Companies"
    }
        [BsonElement("company_name")]
        public string Name { get; set; }
        [BsonId]
        public ObjectId  ID { get; set; }

      
    }
    public class Users:BaseDocument
    {
    public Users()
    {
        base.NameCollection = "users"

       //        [BsonId]
       [BsonElement("tz")]
        public string TZ { get; set; }
        //[BsonRepresentation(BsonType.ObjectId)]

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("fname")]
        public string FirstName { get; set; }

     
        [BsonElement("lname")]
        public string LastName { get; set; }


        [BsonElement("telfone")]
        public string Telfone { get; set; }

        [BsonElement("company")]
        public string company { get; set; }
       
    }
}
