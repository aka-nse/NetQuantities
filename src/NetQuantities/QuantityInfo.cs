using System;
using System.Collections.Generic;
using System.Text;

namespace NetQuantities;

public record QuantityInfo
{
    public record DimensionInfo
    {
        public int L { get; }
        public int M { get; }
        public int T { get; }
        public int I { get; }
        public int Th { get; }
        public int N { get; }
        public int J { get; }

        internal DimensionInfo(int L, int M, int T, int I, int Th, int N, int J)
        {
            this.L = L;
            this.M = M;
            this.T = T;
            this.I = I;
            this.Th = Th;
            this.N = N;
            this.J = J;
        }

        public override string ToString()
        {
            static void setup(StringBuilder sb, string symbol, int value, ref string space)
            {
                if(value == 0)
                {
                    return;
                }

                if(value == 1)
                {
                    sb.Append($"{space}{symbol}");
                }
                else
                {
                    sb.Append($"{space}{symbol}^{value}");
                }
                space = " ";
            }

            var space = "";
            var sb = new StringBuilder();
            setup(sb, nameof(L ), L , ref space);
            setup(sb, nameof(M ), M , ref space);
            setup(sb, nameof(T ), T , ref space);
            setup(sb, nameof(I ), I , ref space);
            setup(sb, nameof(Th), Th, ref space);
            setup(sb, nameof(N ), N , ref space);
            setup(sb, nameof(J ), J , ref space);
            return sb.ToString();
        }
    }

    public string Name { get; }
    public DimensionInfo Dimension { get; }

    internal QuantityInfo(string Name, int L, int M, int T, int I, int Th, int N, int J)
    {
        this.Name = Name;
        Dimension = new(L, M, T, I, Th, N, J);
    }
}