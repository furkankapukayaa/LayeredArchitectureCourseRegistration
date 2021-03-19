using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private string dersad;
        private int min;
        private int max;
        private int id;


        public string Dersad { get => dersad; set => dersad = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public int Id { get => id; set => id = value; }
    }
}
