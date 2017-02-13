using LIBDeveloper;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WPFDeveloper.Helpers;
using WPFDeveloper.View;
using WPFDeveloper.WCFDeveloperReference;

namespace WPFDeveloper.ViewModel
{
    public class ViewModelMain : ViewModelBase
    {

        #region Private Fields
        /// <summary>
        /// ObservableCollection of the avalaible ProgrammingLanguage
        /// </summary>
        private ObservableCollection<ProgrammingLanguage> _avalaibleLanguages;

        /// <summary>
        /// Field of the curent selected Developer
        /// </summary>
        private Developer _currentDeveloper;

        /// <summary>
        /// Field of the current avalaibleLanguge selected
        /// </summary>
        private ProgrammingLanguage _currentAvailableLanguage;

        /// <summary>
        /// Field of the current known language selected
        /// </summary>
        private ProgrammingLanguage _currentKnownLanguage;     
        #endregion

        #region Public Properties
        /// <summary>
        /// ObservableCollection of Developer
        /// </summary>
        public ObservableCollection<Developer> Developers { get; set; }
               
        /// <summary>
        /// Set or get the _avalaibleLanguages field
        /// </summary>
        public ObservableCollection<ProgrammingLanguage> AvalaiblebLanguages
        {
            get
            {
                if (CurrentDeveloper != null)
                {
                    IEnumerable<ProgrammingLanguage> test = _avalaibleLanguages.Except(CurrentDeveloper.ProgrammingLanguages, new ProgrammingLanguageComparer());
                    return new ObservableCollection<ProgrammingLanguage>(test);
                }
                else
                    return _avalaibleLanguages;
            }
            set
            {
                _avalaibleLanguages = value;
            }
        }

        /// <summary>
        /// Set or get the _currentDeveloper field
        /// </summary>
        public Developer CurrentDeveloper
        {
            get
            {
                return _currentDeveloper;
            }
            set
            {
                if (_currentDeveloper != value)
                {
                    _currentDeveloper = value;
                    NotifyPropertyChanged("CurrentDeveloper");
                    NotifyPropertyChanged("AvalaiblebLanguages");
                }
            }
        }

        
        /// <summary>
        /// Set or get the _currentAvailableLanguage field
        /// </summary>
        public ProgrammingLanguage CurrentAvailableLanguage
        {
            get
            {
                return _currentAvailableLanguage;
            }
            set
            {
                if (_currentAvailableLanguage != value)
                {
                    _currentAvailableLanguage = value;
                    NotifyPropertyChanged("CurrentAvailableLanguage");                   
                }
            }
        }

        /// <summary>
        /// Set or get the _currentDeveloper field
        /// </summary>
        public ProgrammingLanguage CurrentKnownLanguage
        {
            get
            {
                return _currentKnownLanguage;
            }
            set
            {
                if (_currentKnownLanguage != value)
                {
                    _currentKnownLanguage = value;
                    NotifyPropertyChanged("CurrentKnownLanguage");                   
                }
            }
        }

        /// <summary>
        /// Connexion service
        /// </summary>
        WCFDeveloperClient Service { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor of the ViewModelMain
        /// </summary>
        public ViewModelMain()
        {
            Service = new WCFDeveloperReference.WCFDeveloperClient();

            //Initialize Developer datagrid
            Developers = new ObservableCollection<Developer>();
            InitializeDeveloper(Service);

            //Initialize programming language datagrid
            AvalaiblebLanguages = new ObservableCollection<ProgrammingLanguage>();
            InitializeProgrammingLanguage(Service);

            //Initialize commands
            LaunchDevelopersCommand = new RelayCommand(LaunchDevelopers);
            AddLanguageCommand = new RelayCommand(AddLanguageToDev, x => CanExecuteLanguageCommands());
            RemoveLanguageCommand = new RelayCommand(RemoveLanguageToDev, x => CanExecuteLanguageCommands());
            SaveDeveloperCommand = new RelayCommand(SaveDevelopers);
        }

        /// <summary>
        /// Initialize the datagrid which contains programming language
        /// </summary>
        /// <param name="service"></param>
        private void InitializeProgrammingLanguage(WCFDeveloperClient service)
        {
            this.AvalaiblebLanguages = new ObservableCollection<ProgrammingLanguage>(service.GetProgrammingLanguages());
        }

        /// <summary>
        /// Initialize the datagrid which contains developers
        /// </summary>
        /// <param name="service"></param>
        private void InitializeDeveloper(WCFDeveloperClient service)
        {
            this.Developers = new ObservableCollection<Developer>(service.GetDevelopers());
        }
        #endregion

        #region Command    
        /// <summary>
        /// Command for launch the window for handling developers
        /// </summary>
        public RelayCommand LaunchDevelopersCommand { get; set; }

        /// <summary>
        /// Launch the window for handling developers
        /// </summary>
        /// <param name="obj"></param>
        private void LaunchDevelopers(object obj)
        {
            var win = new DevelopersView { DataContext = new ViewModelDevelopers(this.Developers) };
            win.ShowDialog();            
        }

        public RelayCommand AddLanguageCommand { get; set; }

        /// <summary>
        /// Add a programming language to a developers
        /// </summary>
        /// <param name="obj"></param>
        private void AddLanguageToDev(object obj)
        {
            if(this.CurrentDeveloper != null && this.CurrentAvailableLanguage != null)
            {
                this.CurrentDeveloper.ProgrammingLanguages.Add(CurrentAvailableLanguage);
                NotifyPropertyChanged("AvalaiblebLanguages");                                              
            }
        }

        /// <summary>
        /// Indique weither or not the add button can be used
        /// </summary>
        /// <returns></returns>
        private bool CanExecuteLanguageCommands()
        {
            return CurrentDeveloper != null;
        }

        /// <summary>
        /// Commande to remove a developer language
        /// </summary>
        public RelayCommand RemoveLanguageCommand { get; set; }

        /// <summary>
        /// Remove a language from dev's programming languages list
        /// </summary>
        /// <param name="obj"></param>
        private void RemoveLanguageToDev(object obj)
        {
            if (this.CurrentDeveloper != null && this.CurrentKnownLanguage != null)
            {
                this.CurrentDeveloper.ProgrammingLanguages.Remove(CurrentKnownLanguage);
                NotifyPropertyChanged("AvalaiblebLanguages");
            }
        }

        /// <summary>
        /// Command to save developers
        /// </summary>
        public RelayCommand SaveDeveloperCommand { get; set; }

        /// <summary>
        /// Save developers
        /// </summary>
        /// <param name="obj"></param>
        private void SaveDevelopers(object obj)
        {
            Service.SaveDevelopers(Developers.ToArray());
            System.Windows.MessageBox.Show("Changes have been saved", "Info");
        }
        #endregion
    }
}
