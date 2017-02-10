using LIBDeveloper;
using System.Collections.Generic;

namespace WPFDeveloper.Helpers
{
    public class ProgrammingLanguageComparer : IEqualityComparer<ProgrammingLanguage>
    {
        public bool Equals(ProgrammingLanguage x, ProgrammingLanguage y)
        {
            return x.LanguageName == y.LanguageName;             
        }

        public int GetHashCode(ProgrammingLanguage obj)
        {
            //Get hash code for the Name field if it is not null. 
            int hashProductName = obj.LanguageName == null ? 0 : obj.LanguageName.GetHashCode();

            //Calculate the hash code for the product. 
            return hashProductName;
        }
    }
}
