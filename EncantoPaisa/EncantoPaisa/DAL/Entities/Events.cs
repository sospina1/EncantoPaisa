namespace EncantoPaisa.DAL.Entities
{
    public class Events : AuditBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RealizationDate { get; set; }
        public DateTime Site { get; set; }
        public string? Cost { get; set; }
    }
}