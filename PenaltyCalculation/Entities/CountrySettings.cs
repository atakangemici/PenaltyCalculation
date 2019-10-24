using MyProjectIndirimix.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PenaltyCalculation.Entities
{
    public class CountrySettings : BaseEntity
    {
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public double PenaltyPrice { get; set; }

    }
}