using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringCodeChallenge
{
    public class TestResult
    {
        public string RunId { get; set; }
        public string TestName { get; set; }
        public string Status { get; set; }
        public int? DurationMs { get; set; }
    }
}
