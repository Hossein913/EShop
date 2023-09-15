using Microsoft.AspNetCore.Identity;

namespace App.Domain.Core.Entities;
public class Role : IdentityRole<int>
{
    public string Description { get; set; }
}
