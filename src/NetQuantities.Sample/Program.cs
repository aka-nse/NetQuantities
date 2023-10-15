// See https://aka.ms/new-console-template for more information
using NetQuantities;
using NetQuantities.Generic;
using System.Numerics;

NonGenericSample();
static void NonGenericSample()
{
    var length = QLength.FromMetre(600);
    var time = QTime.FromSecond(33.5);
    var speed = length / time;
    Console.WriteLine($"{speed:0.00& [km/h]}");
}

#if NET7_0_OR_GREATER

GenericSample();
static void GenericSample()
{
    var length = QLength<decimal>.FromMetre(600m);
    var time = QTime<decimal>.FromSecond(33.5m);
    var speed = length / time;
    Console.WriteLine($"{speed:0.00& [km/h]}");
}
#endif
