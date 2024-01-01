using System;
using System.Collections.Generic;
using System.Text;


namespace QuantitiesDotNet
{
    /// <summary>
    /// Provides unit symbols.
    /// Though this type is used on "using static" directive,
    /// please note that many simple symbols
    /// (e.g. <c>s</c>, <c>m</c>, <c>g</c>, <c>V</c>, <c>A</c>, <c>N</c>, <c>J</c>, <c>W</c>, and so on) are defined
    /// and they will be exposed into user code namespace.
#if NET7_0_OR_GREATER
    /// And using generic version together is not available because of name conflict.
#endif
    /// </summary>
    public static partial class UnitShorthands
    {
    }
}


#if NET7_0_OR_GREATER

namespace QuantitiesDotNet.Generic
{
    /// <summary>
    /// Provides unit symbols.
    /// Though this type is used on "using static" directive,
    /// please note that many simple symbols
    /// (e.g. <c>s</c>, <c>m</c>, <c>g</c>, <c>V</c>, <c>A</c>, <c>N</c>, <c>J</c>, <c>W</c>, and so on) are defined
    /// and they will be exposed into user code namespace.
    /// And using non-generic version together is not available because of name conflict.
    /// </summary>
    public static partial class UnitShorthands
    {
    }
}

#endif
