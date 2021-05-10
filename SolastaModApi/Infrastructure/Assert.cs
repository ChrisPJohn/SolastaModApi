using JetBrains.Annotations;
using System;

namespace SolastaModApi.Infrastructure
{
    public static class Assert
    {
        public static void IsNotNull<T>([NotNull, NoEnumeration] T instance, string message = null) where T : class
        {
            if (instance == null)
            {
                throw new NullReferenceException(message ?? string.Empty);
            }
        }
    }
}
