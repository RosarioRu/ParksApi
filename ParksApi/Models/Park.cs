namespace ParksApi.Models
{
    public class Park
    {
        public int ParkId{ get; init; }
        public string ParkName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime DateEstablished { get; init; }
        public int AreaInAcres { get; set}
    } 
}

