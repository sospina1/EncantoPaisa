namespace EncantoPaisa.DAL.Entities
{
    public class Restaurants : AuditBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string address { get; set; }
    }
}
