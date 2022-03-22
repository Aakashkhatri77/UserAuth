using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UserAuth.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AuthUser class
public class AuthUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

