using System.ComponentModel;

namespace WPFDeveloper.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Event Property Changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Implementation of Property Changed
        /// </summary>
        /// <param name="pProp">Property's name</param>
        protected void NotifyPropertyChanged(string pProp)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pProp));
        } 
    }
}
