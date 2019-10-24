using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectIndirimix.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Deleted { get; set; }
    }
}