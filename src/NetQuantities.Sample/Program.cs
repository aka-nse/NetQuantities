﻿// See https://aka.ms/new-console-template for more information
using NetQuantities;
using NetQuantities.Samples;

var samples = new IUsageSample[]
{
    new BasicUsage(),
    new Formatting(),
    new Parsing(),
    new ReinterpretCast(),
    new Generics(),
    new UnitShorthandsUsage(),
};

foreach(var sample in samples)
{
    Console.WriteLine($"【{sample.SampleName}】");
    sample.Execute(Console.Out);
    Console.WriteLine();
}
