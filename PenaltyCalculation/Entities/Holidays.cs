using MyProjectIndirimix.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PenaltyCalculation.Entities
{
    public class Holidays : BaseEntity
    {
        public int CountryId { get; set; }
        public DateTime Holiday { get; set; }

    }
}