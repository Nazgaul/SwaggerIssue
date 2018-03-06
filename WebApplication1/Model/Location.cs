using System.ComponentModel;

namespace WebApplication1.Model
{
    public class Location
    {
        [DefaultValue(0f)]
        public float Long { get; set; }
        [DefaultValue(0f)]
        public float Lat { get; set; }
    }
}