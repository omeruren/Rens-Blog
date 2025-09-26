using RensBlog.Domain.Entities.Common;

namespace RensBlog.Domain.Entities;

public class ContactInfo : BaseEntity
{
    public string Address { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }
    public string MapUrl { get; set; }
}
