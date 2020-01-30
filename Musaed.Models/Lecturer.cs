using Newtonsoft.Json;
using System.Collections.Generic;

namespace Musaed.Models
{
    public class Lecturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
