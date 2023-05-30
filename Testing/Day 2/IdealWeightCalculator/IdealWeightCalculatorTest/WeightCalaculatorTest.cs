using FluentAssertions;
using IdealWeightCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace IdealWeightCalculatorTest
{
    [TestClass]
    public class WeightCalaculatorTest
    {
        // Unit Name =>  Given - When - Then 
        [TestMethod]
        [Description("this is description for tets function")]
        [Owner ("Ahmed")]
        [Priority(1)]
        [TestCategory("Gender")]
        //[Ignore]
        [Timeout(10)]
        public void GetIdealWeight_Gender_Male_Height_170_Result_65()
        {
            /*
           The AAA (Arrange-Act-Assert) pattern has become almost a standard across the industry. It suggests that you should divide your test method 
           into three sections: arrange, act and assert. Each one of them only responsible for the part in which they are named after.

           So the arrange section you only have code required to setup that specific test. Here objects would be created, mocks 
           setup (if you are using one) and potentially expectations would be set. Then there is the Act, which should be the invocation of the method being tested. And on Assert you would simply check whether the expectations were met. More info can be found HERE.

           Following this pattern does make the code quite well structured and easy to understand. In general lines, it would look like this:
             */

            //Arrange
            WeightCalaculator we = new WeightCalaculator() { Gender='m',Height=170};
            //Act
             float ActualResult =we.GetIdealWeight();
            //Assert
            Assert.AreEqual(65, ActualResult);


        }
        [TestMethod]
        public void GetIdealWeight_Gender_FeMale_Height_170_Result_60()
        {

            //Arrange
            WeightCalaculator we = new WeightCalaculator() { Gender = 'f', Height = 170 };
            //Act
            float ActualResult = we.GetIdealWeight();
            //Assert
            Assert.AreEqual(60, ActualResult);


        }
        [TestMethod]
        public void GetIdealWeight_Gender_BadGender_Height_170_Result_0()
        {

            //Arrange
            WeightCalaculator we = new WeightCalaculator() { Gender = ' ', Height = 170 };
            //Act
            float ActualResult = we.GetIdealWeight();
            //Assert
            Assert.AreEqual(0, ActualResult);


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetIdealBodyWeight_Gender_BadGender_And_Height_180_Throw_Exception()
        {
            //Arrange
            WeightCalaculator sut = new WeightCalaculator() { Gender = 'r', Height = 180 };//sut =>system under testing
            //Act                                                                             // Act
            double actual = sut.GetIdealWeight();
            double expected = 65;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Assert_Test()
        {
            //Assert.AreEqual(90, 100);
            //Assert.AreNotEqual(90, 100);

            //WeightCalaculator Calc1 = new WeightCalaculator();
            ////WeightCalaculator Calc2 = Calc1;
            //WeightCalaculator Calc2 = new WeightCalaculator();
            //Assert.AreSame(Calc1, Calc2);

            //WeightCalaculator Calc3 = new WeightCalaculator();
            //Assert.IsInstanceOfType(Calc3, typeof(WeightCalaculator));
            //int x=4;
            //Assert.IsInstanceOfType(x, typeof(int));
            //Assert.IsInstanceOfType(Calc3, typeof(string));

            Assert.IsTrue(10 == 10);
            

        }

        [TestMethod]
        public void String_Assert_Test()
        {
            string Text = "Hello from ITI";

            //StringAssert.Contains(Text, "Ahmed");

            //StringAssert.EndsWith(Text, "ITI");
            StringAssert.StartsWith(Text, "Hello");
        }

        [TestMethod]
        public void Fluent_Assert()
        {
            string Name = "Ahmed";
            //StringAssert.Contains(Name, "M");
            //Name.Should().StartWith("M");
            Name.Should().Contain("A");
        }

        [TestMethod]
        public void Collection_Assert()
        {

            List<string> Li = new List<string> { "Ahmed", "Mohamed", "Mostafa" };

            //CollectionAssert.AllItemsAreNotNull(Li);

            CollectionAssert.Contains(Li, "Ahmed");
           

        }


        [ClassInitialize]
        public static void ClassInitialize(TestContext Context)
        {
            Console.WriteLine("in Class Initialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {

        }
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("in Test Initialize");
        }
        [TestCleanup]
        public void TestCleanup()
        {
        }

    }
}
