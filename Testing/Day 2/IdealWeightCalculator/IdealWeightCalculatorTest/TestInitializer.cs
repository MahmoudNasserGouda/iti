using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWeightCalculatorTest
{
    [TestClass]
    class TestInitializer
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext Context)
        {
            Console.WriteLine("in Assembly Initialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {


        }
    }
}
