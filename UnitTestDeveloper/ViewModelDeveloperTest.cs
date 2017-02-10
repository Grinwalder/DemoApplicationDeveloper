using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LIBDeveloper;
using System.Collections.ObjectModel;
using WPFDeveloper.ViewModel;
using System.Collections.Generic;

namespace UnitTestDeveloper
{
    [TestClass]
    public class ViewModelDeveloperTest
    {
        [TestMethod]
        public void TestAddDeveloperCommand()
        {
            ViewModelDevelopers givenViewModel = new ViewModelDevelopers(new ObservableCollection<Developer>());
            
            givenViewModel.FirstName = "John";
            givenViewModel.LastName = "Doe";
            givenViewModel.AddDeveloperCommand.Execute(null);

            Assert.IsNotNull(givenViewModel.Developers);             
        }

        [TestMethod]
        public void TestCanAddDeveloperCommand()
        {
            ViewModelDevelopers givenViewModel = new ViewModelDevelopers(new ObservableCollection<Developer>());

            givenViewModel.FirstName = "John";         

            Assert.AreEqual(false, givenViewModel.AddDeveloperCommand.CanExecute(null));
        }

        [TestMethod]
        public void TestCanAddDeveloperCommand2()
        {
            ViewModelDevelopers givenViewModel = new ViewModelDevelopers(new ObservableCollection<Developer>());

            givenViewModel.LastName = "Doe";

            Assert.AreEqual(false, givenViewModel.AddDeveloperCommand.CanExecute(null));
        }
    }
}
