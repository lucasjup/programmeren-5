using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwenWebsite.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public int Participants { get; set; }

        public int MaxParticipants { get; set; }

        public DateTime Date { get; set; }

        public decimal Duration { get; set; }

        public decimal Price { get; set; }
    }
}
