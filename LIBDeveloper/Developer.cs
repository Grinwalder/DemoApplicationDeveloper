using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace LIBDeveloper
{
    [DataContract]
    public class Developer
    {
        /// <summary>
        /// Set or get developer's id
        /// </summary>   
        [DataMember]
        public int IdDeveloper { get; set; }

        /// <summary>
        /// Set or Get the first name field
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Set or get the last name field
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Set or Get the programming languages field
        /// </summary>
        [DataMember]
        public ObservableCollection<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        /// <summary>
        /// Constructor of the developer class
        /// </summary>
        /// <param name="pIdDeveloper"></param>
        /// <param name="pFirstName"></param>
        /// <param name="pLastName"></param>
        /// <param name="pLanguages"></param>
        public Developer(int pIdDeveloper, string pFirstName, string pLastName, ObservableCollection<ProgrammingLanguage> pLanguages)
        {
            this.IdDeveloper = pIdDeveloper;
            this.FirstName = pFirstName;
            this.LastName = pLastName;
            this.ProgrammingLanguages = pLanguages;
        }

        /// <summary>
        /// Constructor of the developer class
        /// </summary>
        /// <param name="pIdDeveloper"></param>
        /// <param name="pFirstName"></param>
        /// <param name="pLastName"></param>
        public Developer(int pIdDeveloper, string pFirstName, string pLastName)
        {
            this.IdDeveloper = pIdDeveloper;
            this.FirstName = pFirstName;
            this.LastName = pLastName;
            ProgrammingLanguages = new ObservableCollection<ProgrammingLanguage>();
        }

        /// <summary>
        /// Constructor of the developer class
        /// </summary>     
        /// <param name="pFirstName"></param>
        /// <param name="pLastName"></param>
        public Developer(string pFirstName, string pLastName)
        {
            this.FirstName = pFirstName;
            this.LastName = pLastName;
            ProgrammingLanguages = new ObservableCollection<ProgrammingLanguage>();
        }
    }
}