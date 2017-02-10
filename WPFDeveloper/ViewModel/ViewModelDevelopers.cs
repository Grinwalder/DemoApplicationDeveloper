using LIBDeveloper;
using System.Collections.ObjectModel;
using WPFDeveloper.Helpers;

namespace WPFDeveloper.ViewModel
{
    public class ViewModelDevelopers : ViewModelBase
    {
        /// <summary>
        /// Field of the first name
        /// </summary>
        private string _firstName;

        /// <summary>
        /// Field of the last name
        /// </summary>
        private string _lastName;

        /// <summary>
        /// ObservableCollection of Developer
        /// </summary>
        public ObservableCollection<Developer> Developers { get; set; }

        /// <summary>
        /// Set or Get the first name field 
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Set or Get the last name field
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }
      
        /// <summary>
        /// Constructor of the viewModel Developer
        /// </summary>
        /// <param name="pDevelopers"></param>
        public ViewModelDevelopers(ObservableCollection<Developer> pDevelopers)
        {
            AddDeveloperCommand = new RelayCommand(AddDeveloper, x => this.CanExecuteAddCommand());        
            Developers = pDevelopers;
        }
      

        #region Command
        /// <summary>
        /// Command of the Add button
        /// </summary>
        public RelayCommand AddDeveloperCommand { get; set; }

        /// <summary>
        /// Command of the Save button
        /// </summary>
        public RelayCommand CloseDeveloperCommand { get; set; }
        #endregion

        #region Private Properties
        /// <summary>
        /// Add a developers to the list of developers
        /// </summary>
        /// <param name="parameter"></param>
        private void AddDeveloper(object parameter)
        {
            this.Developers.Add(new Developer(this.FirstName, this.LastName));
        }

        /// <summary>
        /// Indique weither or not the add button can be used
        /// </summary>
        /// <returns></returns>
        private bool CanExecuteAddCommand()
        {
            return !string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(FirstName);
        }
        #endregion
    }
}
