using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Colorful
{
    /// <summary>
    /// Exposes methods and properties that represent a style classification.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StyleClass<T> : IEquatable<StyleClass<T>>
    {
        /// <summary>
        /// The object to be styled.
        /// </summary>
        public T Target { get; protected set; }
        /// <summary>
        /// The color to be applied to the target.
        /// </summary>
        public Color Color { get; protected set; }

        /// <summary>
        /// Exposes methods and properties that represent a style classification.
        /// </summary>
        public StyleClass()
        {
        }

        /// <summary>
        /// Exposes methods and properties that represent a style classification.
        /// </summary>
        /// <param name="target">The object to be styled.</param>
        /// <param name="color">The color to be applied to the target.</param>
        public StyleClass(T target, Color color)
        {
            Target = target;
            Color = color;
        }

        public bool Equals(StyleClass<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.Target.Equals(other.Target)
                && this.Color == other.Color;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as StyleClass<T>);
        }

        public override int GetHashCode()
        {
            int hash = 163;

            hash *= 79 + Target.GetHashCode();
            hash *= 79 + Color.GetHashCode();

            return hash;
        }
    }
}
