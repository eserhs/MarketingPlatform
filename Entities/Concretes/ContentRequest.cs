using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class ContentRequest:IEntity
    {
        public int ContentRequestID { get; set; }
        public int CompanyID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public string ContentType { get; set; }
        public DateTime Deadline { get; set; }
        public decimal Budget { get; set; }
        public string status { get; set; } = "pending";
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }

    }
}
