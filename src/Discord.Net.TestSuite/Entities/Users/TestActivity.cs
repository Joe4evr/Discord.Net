using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.TestSuite.Models
{
    internal class TestActivity : IActivity
    {
        public string Name { get; }
        public ActivityType Type { get; }
    }
}
