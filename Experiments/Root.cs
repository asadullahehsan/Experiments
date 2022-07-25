using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    public class Root
    {
        public Sms sms { get; set; }
    }

    public class Sms
    {
        public string status { get; set; }
        public string timestamp { get; set; }
    }
}
