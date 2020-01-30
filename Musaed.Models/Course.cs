using Newtonsoft.Json;
using System.Collections.Generic;

namespace Musaed.Models
{
    public class Course
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string Description { get; set; }

        public int LecturerId { get; set; }

        [JsonIgnore]
        public virtual Lecturer Lecturer { get; set; }

    }
}
