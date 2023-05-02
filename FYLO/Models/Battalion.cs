namespace FYLO.Models
{
    public class Battalion
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public Base Base { get; set; }
        public Brigade Brigade { get; set; }
    }
}
