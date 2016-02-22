using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportUnit.Model
{
    public class Scenario
    {
        public string Title { get; set; }

        public List<string> Steps { get; set; } = new List<string>();
    }
}
