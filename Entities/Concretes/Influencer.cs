using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Influencer : IEntity
    {
        public int InfluencerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public String PhoneNumber { get; set; } 
        public string SocialMediaHandles { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureURL { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
