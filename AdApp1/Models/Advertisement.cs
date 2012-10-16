using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdApp1.ViewModels;

namespace AdApp1.Models
{
    public class Advertisement
    {
        public int AdvertisementId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExporationDate { get; set; }
        public virtual Business Business { get; set; }
        public virtual Heading Heading { get; set; }
        public virtual ICollection<Region> Regions { get; set; }

        public Advertisement()
        {
        }

        public Advertisement(ViewModelAdvertisement vmAd) : this()
        {
            this.AdvertisementId = vmAd.AdvertisementId;
            this.EffectiveDate = vmAd.EffectiveDate;
            this.ExporationDate = vmAd.ExporationDate;
            
            if (this.Heading == null)
            {
               this.Heading = new Heading(); 
            }

            this.Heading.HeadingId = vmAd.HeadingId;
            this.Heading.Text = vmAd.HeadingText;

            if (this.Regions == null)
            {
                this.Regions = new List<Region>();
            }
        }
    }
}