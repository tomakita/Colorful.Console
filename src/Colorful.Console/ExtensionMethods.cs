using System.Collections.Generic;

namespace Colorful
{
    internal static class ExtensionMethods
    {
        internal static IEnumerable<T> Prototype<T>(this IEnumerable<T> input) where T : IPrototypable<T>
        {
            foreach (T item in input)
            {
                yield return item.Prototype();
            }
        }

        internal static IEnumerable<T> DeepCopy<T>(this IEnumerable<T> input) where T : struct
        {
            foreach (T item in input)
            {
                yield return item;
            }
        }

        /// <summary>
        /// Convenience wrapper around the String.Join method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static string AsString<T>(this T input)
        {
            // Cast to dynamic due to type inference shortcomings.  If input is an array,
            // and we pass it to the String.Join method (which takes arguments of type 'string'
            // and 'params object[]'), the compiler will think that String.Join is
            // being passed an array of arrays.  This is not necessarily incorrect, but I think
            // that in most cases, if we're passing an array into String.Join, the intention is
            // for it to be "unrolled" into a collection of the array's elements, rather than the
            // default behavior described previously.
            return string.Join(string.Empty, (dynamic)input);
        }

        // TODO: NO DYNAMIC IN .NET CORE
        /// <summary>
        /// Takes a single object (which could be a 1-dimensional array) and returns it (or, potentially,
        /// all of its elements) as an element of an array of the corresponding type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">The object which will be transformed into an array.</param>
        /// <returns>An array of a certain type, as dynamic.</returns>
        internal static dynamic Normalize<T>(this T input)
        {
            // See the AsString<T> method for a comment relating to part of the dynamic return type
            // of this method.

            List<dynamic> output = new List<dynamic>();
            dynamic[] inputAsArray = input as dynamic[];

            if (inputAsArray != null)
            {
                output.AddRange(inputAsArray);
            }
            else
            {
                output.Add((dynamic)input);
            }

            return output.ToArray();
        }
    }
}
