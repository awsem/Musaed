using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musaed.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Matric { get; set; }

        public ICollection<Course> Courses { get; set; }
        
    }
}
