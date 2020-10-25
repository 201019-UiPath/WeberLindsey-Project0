namespace StoreLib
{
    public class Location
    {
        private int id { get; set; }
        private string street1 { get; set; }
        private string street2 { get; set; }
        private string city { get; set; }
        private string state { get; set;}
        private string postalCode { get; set; }
        private string[] inventory { get; set; }

        Location() {}

        Location(int id, string street1, string street2, string city, string state, string postalCode, string[] inventory) {
            this.id = id;
            this.street1 = street1;
            this.street2 = street2;
            this.city = city;
            this.state = state;
            this.postalCode = postalCode;
            this.inventory = inventory;
        }

    }
}