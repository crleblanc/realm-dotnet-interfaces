using Realms;

namespace RealmInterfaces
{
    public partial class SubclassRealmEntity : RealmObject
    {
        [PrimaryKey]
        public MongoDB.Bson.ObjectId Id { get; set; }
        public int Counter { get; set; }
    }

    // We cannot use IRealmObject here because of CS0535 errors:
    public partial class ImplementsRealmInterface : IRealmObject
    {
        [PrimaryKey]
        public MongoDB.Bson.ObjectId Id { get; set; }
        public int Counter { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}