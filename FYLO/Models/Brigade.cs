namespace FYLO.Models
{
    public class Brigade
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public CommandElement CommandElement { get; set; }
        public Base Base { get; set; }
    }
}
