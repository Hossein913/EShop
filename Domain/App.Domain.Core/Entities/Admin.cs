﻿using System;
using System.Collections.Generic;

namespace App.Domain.Core.Entities;

public partial class Admin
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? PersonalCode { get; set; }


}
