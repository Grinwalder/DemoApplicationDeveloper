using WCFDeveloper.EntityModel;
using LIBDeveloper;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace WCFDeveloper
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "WCFDeveloper" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez WCFDeveloper.svc ou WCFDeveloper.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class WCFDeveloper : IWCFDeveloper
    {
        public DBDeveloperEntities _entities = new DBDeveloperEntities();

        public void DoWork()
        {
        }        
            
        /// <summary>
        /// Return a developer list from the entity data model
        /// </summary>
        /// <returns></returns>
        public List<LIBDeveloper.Developer> GetDevelopers()
        {
            try
            {

                return _entities.Developers.ToList().Select(x => new LIBDeveloper.Developer(x.IdDeveloper, x.FirstName, x.LastName, new ObservableCollection<ProgrammingLanguage>((x.Languages.Select(y => new LIBDeveloper.ProgrammingLanguage(y.IdLanguage, y.LanguageName))).ToList()))).ToList();
            }
            catch
            {
                throw;
            }
                 
        }

        /// <summary>
        /// Return a programmingLanguage list from the entity data model
        /// </summary>
        /// <returns></returns>
        public List<ProgrammingLanguage> GetProgrammingLanguages()
        {
            try
            {
                return _entities.Languages.ToList().AsParallel().Select(x => new ProgrammingLanguage(x.IdLanguage, x.LanguageName)).ToList();
            }
            catch
            {
                throw;
            }       
        }

        /// <summary>
        /// Save in dataBase a developers List from clients
        /// </summary>
        /// <param name="pDevelopers"></param>
        public void SaveDevelopers(List<LIBDeveloper.Developer> pDevelopers)
        {
            _entities.Developers.RemoveRange(_entities.Developers);    
            
            foreach(LIBDeveloper.Developer developerLib in pDevelopers)
            {
                _entities.Developers.Add(new EntityModel.Developer { FirstName = developerLib.FirstName, LastName = developerLib.LastName, Languages = developerLib.ProgrammingLanguages.Select(x => getProgrammingLanguageById(x.IdProgrammingLanguage)).ToList()});                         
            }
            _entities.SaveChanges();
        }

        /// <summary>
        /// Get an entity data model progrmaing language by its Id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public Language getProgrammingLanguageById(int pId)
        {
            return _entities.Languages.Where(x => x.IdLanguage == pId).ToList().ElementAt(0);
        }

        /// <summary>
        /// Get an entity data model developer by its Id
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public EntityModel.Developer getDeveloperById(int pId)
        {
            return _entities.Developers.Where(x => x.IdDeveloper == pId).ToList().ElementAt(0);
        }
    }
}
