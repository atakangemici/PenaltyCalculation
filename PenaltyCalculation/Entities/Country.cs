using MyProjectIndirimix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PenaltyCalculation.Entities
{
    public class Country : BaseEntity
    {
       public string Name { get; set; }
        public string Value { get; set; }

    }
}