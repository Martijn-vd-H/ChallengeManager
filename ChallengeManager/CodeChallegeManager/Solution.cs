using System.Xml.Linq;

namespace CodeChallengeManager
{
    public class Solution
    {
        public Solution(XElement root)
        {
            Code = root.Element("Code")?.Value;
        }

        public Solution()
        {
            
        }

        public string Code { get; set; }

        protected bool Equals(Solution other)
        {
            return string.Equals(Code, other.Code);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Solution) obj);
        }

        public override int GetHashCode()
        {
            return (Code != null ? Code.GetHashCode() : 0);
        }
    }
}