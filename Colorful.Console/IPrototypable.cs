using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colorful
{
    /// <summary>
    /// Exposes methods used for creating (potentially inexact) copies of objects.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPrototypable<T>
    {
        /// <summary>
        /// Returns a potentially inexact copy of the target object.
        /// </summary>
        /// <returns></returns>
        T Prototype();
    }
}
