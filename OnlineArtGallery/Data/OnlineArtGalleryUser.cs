﻿using Microsoft.AspNetCore.Identity;

namespace OnlineArtGallery.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class OnlineArtGalleryUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
