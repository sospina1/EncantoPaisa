using System.ComponentModel.DataAnnotations;

namespace EncantoPaisa.DAL.Entities
{
    public class AuditBase
    {
        [Key]
        public Guid Id { get; set; }

    }
}