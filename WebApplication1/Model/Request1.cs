namespace WebApplication1.Model
{
    public class Request1
    {
        public string SomeType { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        public float Long { get; set; }
        public float Lat { get; set; }
    }
}