namespace Parking
{
    public class ParkingArea
    {
        public int id { get; set; }
        public string parkeringstilbyderNavn { get; set; }
        public float breddegrad { get; set; }
        public float lengdegrad { get; set; }
        public Deaktivert deaktivert { get; set; }
        public int versjonsnummer { get; set; }
        public string navn { get; set; }
        public string adresse { get; set; }
        public string postnummer { get; set; }
        public string poststed { get; set; }
        public DateTime aktiveringstidspunkt { get; set; }
        public bool hasShower { get; set; }
    }

    public class Deaktivert
    {
        public DateTime deaktivertTidspunkt { get; set; }
    }



}
