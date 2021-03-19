using System;
using XamlX.Emit;

namespace XamlX.Transform
{
#if !XAMLX_INTERNAL
    public
#endif
    interface IXamlIdentifierGenerator
    {
        string GenerateIdentifierPart();
    }

#if !XAMLX_INTERNAL
    public
#endif
    class GuidIdentifierGenerator : IXamlIdentifierGenerator
    {
        private int _nextId = 1;
        
        public string GenerateIdentifierPart() => (_nextId++).ToString();
    }
}