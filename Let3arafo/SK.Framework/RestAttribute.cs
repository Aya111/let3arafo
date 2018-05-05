using System;

namespace SK.Framework
{
    /// <summary>
    /// A marker for classes related for REST payload. We will generate automatic typescript definition for all types with these markers
    /// </summary>
    public class RestAttribute : Attribute
    {
    }

    public class RequestPayloadAttribute : Attribute
    {
    }

    public class ReplyPayloadAttribute : Attribute
    {
    }

    public class OptionalAttribute : Attribute
    {
    }
}