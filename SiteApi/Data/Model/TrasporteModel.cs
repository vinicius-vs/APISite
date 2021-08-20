using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class TrasporteModel : BaseModel
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal valor { get; set; }
    }
}
