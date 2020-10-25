namespace StoreLib
{
    public class Location
    {
        int id { get; set; }
        string street1 { get; set; }
        string street2 { get; set; }
        string city { get; set; }
        string state { get; set;}
        string postalCode { get; set; }
        string[] inventory { get; set; }

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