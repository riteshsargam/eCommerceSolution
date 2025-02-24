﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.Entities;

/// <summary>
/// Define the ApplicationUser calss which acts as entity model to store user details in data store
/// </summary>
public class ApplicationUser
{
    public Guid UserID { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? PersonName { get; set; }
    public string? Gender { get; set; }
}


