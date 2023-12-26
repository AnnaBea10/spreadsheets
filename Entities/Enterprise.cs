namespace spreadsheet.Entities
{
    public class Enterprise
    {
        private int id { get; set;}
        private String name { get; set;}
        private String description { get; set; }
        private String adress { get; set; }
        private double price { get; set; } 

        public Enterprise(int id, String name, String description, String adress, double price)
        {
            this.id = id;   
            this.name = name;
            this.description = description;
            this.adress = adress;
            this.price = price;
        }

       

        //HashCode and Equals
        public override bool Equals(object? obj)
        {
            return obj is Enterprise enterprise &&
                   id == enterprise.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
}
