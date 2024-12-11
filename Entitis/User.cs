using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entitis;

public partial class User
{
    public int Id { get; set; }
    [EmailAddress,Required]
    public string Email { get; set; } = null!;
    [StringLength(20,ErrorMessage ="password can between 8-20 letters",MinimumLength =8),Required]
    public string? Password { get; set; }
    [StringLength(20, ErrorMessage = "firstName can between 8-20 letters",MinimumLength =8)]
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
