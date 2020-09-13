using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace SovaApp.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public string OwnerDisplayName { get; set; }

        public DateTime OwnerCreationDate { get; set; }

        public string Location { get; set; }

        public int Age { get; set; }
    }
}
