using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    public class StudentCorse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CorseId { get; set; }
        public Corse Corse { get; set; }
    }
}
