using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colorful
{
    /// <summary>
    /// Exposes properties describing the indices of the beginning and end of a pattern match.
    /// </summary>
    public class MatchLocation : IEquatable<MatchLocation>, IComparable<MatchLocation>, IPrototypable<MatchLocation>
    {
        /// <summary>
        /// The index of the beginning of the pattern match.
        /// </summary>
        public int Beginning { get; private set; }
        /// <summary>
        /// The index of the end of the pattern match.
        /// </summary>
        public int End { get; private set; }

        /// <summary>
        /// Exposes properties describing the indices of the beginning and end of a pattern match.
        /// </summary>
        /// <param name="beginning">The index of the beginning of the pattern match.</param>
        /// <param name="end">The index of the end of the pattern match.</param>
        public MatchLocation(int beginning, int end)
        {
            this.Beginning = beginning;
            this.End = end;
        }

        public MatchLocation Prototype()
        {
            return new MatchLocation(Beginning, End);
        }

        public bool Equals(MatchLocation other)
        {
            if (other == null)
            {
                return false;
            }

            return this.Beginning == other.Beginning
                && this.End == other.End;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MatchLocation);
        }

        public override int GetHashCode()
        {
            int hash = 163;

            hash *= 79 + Beginning.GetHashCode();
            hash *= 79 + End.GetHashCode();

            return hash;
        }

        public int CompareTo(MatchLocation other)
        {
            return this.Beginning.CompareTo(other.Beginning);
        }

        public override string ToString()
        {
            return Beginning.ToString() + ", " + End.ToString();
        }
    }
}
