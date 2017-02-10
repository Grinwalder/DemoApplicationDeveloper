using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDeveloper.ViewModel;

namespace UnitTestDeveloper
{
    [TestClass]
    public class ViewModelMainTest
    {
        [TestMethod]
        public void TestInitializeDeveloper()
        {
            ViewModelMain givenViewModel = new ViewModelMain();

            PrivateObject obj = new PrivateObject(givenViewModel);
            var retVal = obj.Invoke("InitializeDevelopers");

            Assert.IsNotNull(givenViewModel.Developers);
        }
    }
}
