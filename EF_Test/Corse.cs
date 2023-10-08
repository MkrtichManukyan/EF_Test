using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test
{
    public class Corse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentCorse> StudentCorse { get; set; }
        public Corse()
        {
            StudentCorse = new List<StudentCorse>();
        }
    }
}
