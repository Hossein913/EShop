namespace EShop.Domain.Core.Entities;

public class Role : IdentityRole<int>
{
    public string Description { get; set; }
}
