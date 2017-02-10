using LIBDeveloper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDeveloper
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IWCFDeveloper" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IWCFDeveloper
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<Developer> GetDevelopers();

        [OperationContract]
        List<ProgrammingLanguage> GetProgrammingLanguages();

        [OperationContract]
        void SaveDevelopers(List<Developer> developers);
    }
}
