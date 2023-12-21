using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetQuantities;

internal interface IUsageSample
{
    public string SampleName { get; }
    public void Execute(TextWriter stdout);
}
