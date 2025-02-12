﻿using System;
using System.Collections.Generic;

namespace Gluon.Core
{
    public static partial class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
        {
            foreach (var item in self)
            {
                action(item);
            }
        }
    }
}
