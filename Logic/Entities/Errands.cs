using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Entities
{
    class Errands
    {
        public string Description { get; set; }
        public List<T> Vehicle { get; set; }
        public List<T> Issue { get; set; }
        public List<T> Mechanic { get; set; }
        public bool Status { get; set; }
    }
}
