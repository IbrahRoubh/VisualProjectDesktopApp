using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisoulProjectDisktopApp.model
{
    internal class Supplies
    {
        public int id { get; set; }
        public int PID { get; set; }
        public int SID { get; set; }
        public int FID { get; set; }
        public int amount { get; set; }
        public string Direction { get; set; }
        public DateTime date_of_arrival { get; set; }
        public String status { get; set; }

    }
}
