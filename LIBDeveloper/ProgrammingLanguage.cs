using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LIBDeveloper
{
    [DataContract]
    public class ProgrammingLanguage
    {
        /// <summary>
        /// Set or get field ProgrammingLanguage's id
        /// </summary>
        [DataMember]
        public int IdProgrammingLanguage { get; set; }

        /// <summary>
        /// Set or Get the field programming language's name
        /// </summary>
        [DataMember]
        public string LanguageName { get; set; }

        /// <summary>
        /// Constructor of the ProgrammingLanguage class
        /// </summary>
        /// <param name="pLanguageName"></param>
        public ProgrammingLanguage(int pIdProgLang, string pLanguageName)
        {
            this.IdProgrammingLanguage = pIdProgLang;
            this.LanguageName = pLanguageName;
        }
    }
}