﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entitis;


public partial class User
{
    public int Id { get; set; }
    [EmailAddress,Required]
    public string Email { get; set; } = null!;
    [StringLength(20,ErrorMessage ="password can be between 8 till 20 chars",MinimumLength =8),Required]
    public string? Password { get; set; }
    [StringLength(20, ErrorMessage = "firstName can be between 2 till 20 chars", MinimumLength = 2), Required]
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
