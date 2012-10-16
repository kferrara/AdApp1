using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdApp1.Models;

namespace AdApp1.ViewModels
{
    public class ViewModelAdvertisement
    {
        public int AdvertisementId { get; set; }
        public int RegionId { get; set; }
        public int RegionTypeId { get; set; }
        public List<RegionType> RegionTypes { get; set; }
        public int BusinessId { get; set; }
        public List<Business> Businesses { get; set; }
        public int HeadingId { get; set; }
        public string HeadingText { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExporationDate { get; set; }

        public ViewModelAdvertisement()
        {
            RegionTypes = new List<RegionType>();
            Businesses = new List<Business>();
        }
    }
}