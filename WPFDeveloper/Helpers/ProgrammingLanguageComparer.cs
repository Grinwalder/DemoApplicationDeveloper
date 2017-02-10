using LIBDeveloper;
using System.Collections.Generic;

namespace WPFDeveloper.Helpers
{
    /// <summary>
    /// See more at https://msdn.microsoft.com/fr-fr/library/ms132151(v=vs.110).aspx
    /// </summary>
    public class ProgrammingLanguageComparer : IEqualityComparer<ProgrammingLanguage>
    {
        /// <summary>
        /// Implementation of Equals to be able execute List.Except on a programming language list
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
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
