using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorControlWork.Data
{
    public class User
    {
        public User(string login, string password, string name, string surname, string email)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
        }

        [BsonIgnoreIfDefault]
        [BsonId]
        ObjectId _id;
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public string returnName()
        {
            return Name;
        }
    }
}
