#if NETSTANDARD2_0 || NETSTANDARD2_1
namespace System.Runtime.CompilerServices
{
    internal class IsExternalInit
    {
    }
}
#endif

#if NETSTANDARD2_0

namespace System.Diagnostics.CodeAnalysis
{
    public class AllowNullAttribute : Attribute { }
    public class DisallowNullAttribute : Attribute { }
    public class MaybeNullAttribute : Attribute { }
    public class NotNullAttribute : Attribute { }
    public class MaybeNullWhenAttribute : Attribute { public MaybeNullWhenAttribute(bool returnValue) { } }
    public class NotNullWhenAttribute : Attribute { public NotNullWhenAttribute(bool returnValue) { } }
    public class DoesnotReturnAttribute : Attribute { }
    public class DoesNotReturnWhenAttribute : Attribute { public DoesNotReturnWhenAttribute(bool parameterValue) { } }
    public class MemberNotNullAttribute : Attribute
    {
        public MemberNotNullAttribute(string member) { }
        public MemberNotNullAttribute(string[] members) { }
    }
    public class MemberNotNullWhenAttribute : Attribute
    {
        public MemberNotNullWhenAttribute(bool returnValue, string member) { }
        public MemberNotNullWhenAttribute(bool returnValue, string[] members) { }
    }
}
#endif
