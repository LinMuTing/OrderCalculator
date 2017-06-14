using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderCalculor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCalculor.Tests
{
    [TestClass()]
    public class ReadOrderTests
    {
        [TestMethod()]
        public void Calculate_Specify_Column_with_Specify_Group()
        {
            //Arrange
            int theGroupYouWant = 4;
            string theColumnYouWant = "Revenue";
            List<int> actual = new List<int>();
            var expaected = new List<int>() { 50, 66, 60 };

            //Act
            ReadOrder target = new ReadOrder(theColumnYouWant, ref actual, theGroupYouWant);

            //Assert
            CollectionAssert.AreEquivalent(expaected, actual);
        }
        
    }
}