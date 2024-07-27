using Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Offer:IEntity
    {
        public int OfferID { get; set; }
        public int ContentRequestID { get; set; }
        public int InfluencerID { get; set; }
        public string Message { get; set; }
        public DateTime OfferDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public decimal Budget { get; set; }



    }
   
}
