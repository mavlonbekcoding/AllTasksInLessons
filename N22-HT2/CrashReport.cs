using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2
{
    public class CrashReport : IReview
    {
        public int Id { get; set; }
        public int Star { get; set; }
        public string Message { get; set; }
        public string Image { get ; set; }
        public string Screenshot { get; internal set; }
    }
}
