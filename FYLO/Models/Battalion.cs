namespace FYLO.Models
{
    public class Battalion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Base Base { get; set; }
        public Brigade Brigade { get; set; }
    }
}
