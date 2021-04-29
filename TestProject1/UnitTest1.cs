using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnigmaMachine;
using System.Collections.Generic;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRotorCreation()
        {

            List<int> fop1 = new List<int> { 17, };
            List<int> fop2 = new List<int> { 5, };
            List<int> fop3 = new List<int> { 22, };

            Rotor rotorOne = new Rotor("Rotor I", 0, fop1);

            string expectedName = "Rotor I";
            int expectedOffset = 0;
            List<int> expectedfop = new List<int> { 17, };

            Assert.AreEqual(rotorOne.Name, expectedName);
            //Assert.AreEqual(rotorOne.RotorOffset, expectedOffset);
            //Assert.AreEqual(rotorOne.FlipOverPoint, expectedfop);


        }

        public void TestRotorCreationFail()
        {
            Rotor rg;

            Assert.ThrowsException<ArgumentException>(() => (rg = new Rotor()));
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test1()
        {

        }
    }
}
