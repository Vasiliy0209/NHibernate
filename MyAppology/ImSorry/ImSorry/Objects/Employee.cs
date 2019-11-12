using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImSorry
{
    class Employee
    {
        public virtual Guid ID { get; set; }
        public virtual string Imya { get; set; }
        public virtual int Age { get; set; }
    }
}
