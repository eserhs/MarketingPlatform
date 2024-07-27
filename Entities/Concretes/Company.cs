using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Company:IEntity
    {
        public int CompanyID { get; set; }  
        public string Name { get; set;}

        public string Email { get; set;}
        public string PhoneNumber { get; set; }
        public string Adderss { get; set; }
        public string WebSite  { get; set; }
        public string Description { get; set; }
        public string logoURL { get; set; }
        public DateTime CreationDate{ get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set;}
        public bool IsActive { get; set; }

    }
}
