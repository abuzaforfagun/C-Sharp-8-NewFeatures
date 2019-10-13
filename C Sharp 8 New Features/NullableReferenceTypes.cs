using System;

namespace C_Sharp_8_New_Features
{
#nullable enable
    public class NullableReferenceTypes
    {
        public NullableReferenceTypes()
        {
            string nonNullableProperty = "Hello world";
            string? nullableProperty = null;
            nonNullableProperty = null;
            Console.WriteLine(nonNullableProperty.Length);
            Console.WriteLine(nullableProperty.Length);
        }
    }
#nullable restore
}
