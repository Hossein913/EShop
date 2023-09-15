using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Entities;

public partial class Customer
{ 
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public bool? IsActive { get; set; } = true;

    public string? Address { get; set; }

    public bool IsDeleted { get; set; } = false;

    public ICollection<Cart>? Carts { get; set; } = null!;


}
