﻿using System;

namespace SK.Framework
{
    public static class Stamp
    {
        public static DateTime DateTime() => global::System.DateTime.UtcNow;

        public static DateTime Date() => global::System.DateTime.UtcNow.Date;

        public static string ETag() => Guid.NewGuid().ToString();

        public static string System() => "System";
    }
}