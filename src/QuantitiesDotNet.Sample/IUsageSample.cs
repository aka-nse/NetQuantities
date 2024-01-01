using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantitiesDotNet;

internal interface IUsageSample
{
    public string SampleName { get; }
    public void Execute(TextWriter stdout);
}
