namespace FYLO.Models
{
    public class Brigade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Command Command { get; set; }
        public Base Base { get; set; }
    }
}
