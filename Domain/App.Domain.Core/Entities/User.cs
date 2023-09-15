using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Core.Entities;

public class User : IdentityUser<int>
{

}
