
namespace spreadsheet.Entities
{
    public class Client
    {
        private int id { get; set; }
        private String name { get; set; }
        private String phone { get; set; }
        private String email { get; set; }

        public Client(int id, string name, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        //HashCode and Equals
        public override bool Equals(object? obj)
        {
            return obj is Client client &&
                   id == client.id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
}
