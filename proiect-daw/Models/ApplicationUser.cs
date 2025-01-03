﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proiect_daw.Models
{
    public class ApplicationUser : IdentityUser
    {
        // un user poate posta mai multe comentarii
        public virtual ICollection<Comment>? Comments { get; set; }

        // un user poate posta mai multe postari
        public virtual ICollection<Post>? Posts { get; set; }

        public virtual ICollection<Bookmark>? Bookmarks { get; set; }

        public virtual ICollection<FollowRequest>? SentFollowRequests { get; set; }
        public virtual ICollection<FollowRequest>? ReceivedFollowRequests { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public bool PrivateProfile { get; set; }

        public string? ProfileDescription { get; set; }
        public string? PhoneNumber { get; set; }

        public string? ProfilePhoto { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem>? AllRoles { get; set; }
    }
}

