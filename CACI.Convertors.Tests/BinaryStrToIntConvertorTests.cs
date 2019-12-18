using CACI_Lib.Converters;
using CACI_Lib.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CACI.Convertors.Tests
{
    [TestClass]
    public class BinaryStrToIntConvertorTests
    {
        [TestMethod]

        public void EnterEmptyString_GetInvalidInputError()
        {
            //Arrange

            BinaryToIntConvertor binaryToIntConvertor = new BinaryToIntConvertor();
            var ExpectedResult = "Error: Invalid input: Entered string is empty, please enter valid binary string";

            //Act
            var ActualResult = binaryToIntConvertor.Convert("");

            //Assert

            Assert.AreEqual(ExpectedResult, ActualResult);

        }

        [TestMethod]
        public void EnterInvalidString_GetInvalidInputError()
        {
            //Arrange

            string inputString = "afdfgad";
            BinaryToIntConvertor binaryToIntConvertor = new BinaryToIntConvertor();
            var ExpectedResult = "Error: Invalid input: Entered string is not a binary string, please enter valid binary string";

            //Act
            var ActualResult = binaryToIntConvertor.Convert(inputString);

            //Assert

            Assert.AreEqual(ExpectedResult, ActualResult);

        }

        [TestMethod]
        public void EnterValidInputString_Passed_scenerio1()
        {
            //Arrange

            string inputString = "1000";
            BinaryToIntConvertor binaryToIntConvertor = new BinaryToIntConvertor();
            var ExpectedResult = "Integer: 8";

            //Act
            var ActualResult = binaryToIntConvertor.Convert(inputString);

            //Assert

            Assert.AreEqual(ExpectedResult, ActualResult);

        }

        [TestMethod]
        public void EnterValidInputString_Passed_scenerio2()
        {
            //Arrange
            string inputString = "011";
            BinaryToIntConvertor binaryToIntConvertor = new BinaryToIntConvertor();
            var ExpectedResult = "Integer: 3";

            //Act
            var ActualResult = binaryToIntConvertor.Convert(inputString);

            //Assert

            Assert.AreEqual(ExpectedResult, ActualResult);

        }

        [TestMethod]
        public void EnterLargeInputString_Passed()
        {
            //Arrange
            string inputString = "1111111111111111";
            BinaryToIntConvertor binaryToIntConvertor = new BinaryToIntConvertor();
            var ExpectedResult = "Integer: 65535";

            //Act
            var ActualResult = binaryToIntConvertor.Convert(inputString);

            //Assert

            Assert.AreEqual(ExpectedResult, ActualResult);

        }
    }
}
