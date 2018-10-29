using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Awen.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AwenUser class
    public class AwenUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime Birth { get; set; }
        [PersonalData]
        public string Phone { get; set; }
        [PersonalData]
        public string Disability { get; set; }
    }
}
