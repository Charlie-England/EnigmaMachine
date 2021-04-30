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
            Rotor rotorTwo = new Rotor("Rotor II", 15, fop2);
            Rotor rotorThree = new Rotor("Rotor III", 25, fop3);

            string expectedR1Name = "Rotor I";
            string expectedR2Name = "Rotor II";
            string expectedR3Name = "Rotor III";
            int expectedR1Offset = 0;
            int expectedR2Offset = 15;
            int expectedR3Offset = 25;
            List<int> expectedfop = new List<int> { 17, };

            Assert.AreEqual(rotorOne.Name, expectedR1Name);
            Assert.AreEqual(rotorTwo.Name, expectedR2Name);
            Assert.AreEqual(rotorThree.Name, expectedR3Name);
            Assert.AreEqual(rotorOne.RotorOffset, expectedR1Offset);
            Assert.AreEqual(rotorTwo.RotorOffset, expectedR2Offset);
            Assert.AreEqual(rotorThree.RotorOffset, expectedR3Offset);

        }

        public void TestRotorCreationFail()
        {
            Rotor rg;

            Assert.ThrowsException<ArgumentException>(() => (rg = new Rotor()));
        }
    }

    [TestClass]
    public class EnigmaEncodingTests10Chars
    {
        [TestMethod]
        public void TestRotorGroupEnigmaTest1()
        {
            List<int> fop1 = new List<int> { 17, };
            List<int> fop2 = new List<int> { 5, };
            List<int> fop3 = new List<int> { 22, };

            Rotor rotorOne = new Rotor("Rotor III", 0, fop1);
            Rotor rotorTwo = new Rotor("Rotor II", 0, fop2);
            Rotor rotorThree = new Rotor("Rotor I", 0, fop3);

            Reflector reflector = new Reflector("B");

            RotorGroup rg = new RotorGroup(rotorOne, rotorTwo, rotorThree, reflector);

            string expectedOut = "bdzgowcxlt";
            string enigmaOut = "";

            foreach (char c in "aaaaaaaaaa")
            {
                enigmaOut += rg.RotorEncrypt(c);
            }

            Assert.AreEqual(enigmaOut, expectedOut);
        }

        [TestMethod]
        public void TestRotorGroupEnigmaTest2()
        {
            List<int> fop1 = new List<int> { 17, };
            List<int> fop2 = new List<int> { 5, };
            List<int> fop3 = new List<int> { 22, };

            Rotor rotorOne = new Rotor("Rotor III", 1, fop1);
            Rotor rotorTwo = new Rotor("Rotor II", 1, fop2);
            Rotor rotorThree = new Rotor("Rotor I", 1, fop3);

            Reflector reflector = new Reflector("B");

            RotorGroup rg = new RotorGroup(rotorOne, rotorTwo, rotorThree, reflector);

            string expectedOut = "pgqpwitkgv";
            string enigmaOut = "";

            foreach (char c in "aaaaaaaaaa")
            {
                enigmaOut += rg.RotorEncrypt(c);
            }

            Assert.AreEqual(enigmaOut, expectedOut);
        }
        [TestMethod]
        public void TestRotorGroupEnigmaTest3()
        {
            List<int> fop1 = new List<int> { 17, };
            List<int> fop2 = new List<int> { 5, };
            List<int> fop3 = new List<int> { 22, };

            Rotor rotorOne = new Rotor("Rotor III", 25, fop1);
            Rotor rotorTwo = new Rotor("Rotor II", 25, fop2);
            Rotor rotorThree = new Rotor("Rotor I", 25, fop3);

            Reflector reflector = new Reflector("B");

            RotorGroup rg = new RotorGroup(rotorOne, rotorTwo, rotorThree, reflector);

            string expectedOut = "ewtyxqvcwm";
            string enigmaOut = "";

            foreach (char c in "aaaaaaaaaa")
            {
                enigmaOut += rg.RotorEncrypt(c);
            }

            Assert.AreEqual(enigmaOut, expectedOut);
        }

        [TestMethod]
        public void TestRotorGroupEnigmaTest4()
        {
            List<int> fop1 = new List<int> { 17, };
            List<int> fop2 = new List<int> { 5, };
            List<int> fop3 = new List<int> { 22, };

            Rotor rotorOne = new Rotor("Rotor I", 0, fop1);
            Rotor rotorTwo = new Rotor("Rotor II", 0, fop2);
            Rotor rotorThree = new Rotor("Rotor III", 0, fop3);

            Reflector reflector = new Reflector("B");

            RotorGroup rg = new RotorGroup(rotorOne, rotorTwo, rotorThree, reflector);

            string expectedOut = "ftzmgisxip";
            string enigmaOut = "";

            foreach (char c in "aaaaaaaaaa")
            {
                enigmaOut += rg.RotorEncrypt(c);
            }

            Assert.AreEqual(enigmaOut, expectedOut);
        }

        [TestMethod]
        public void TestRotorGroupEnigmaTest5()
        {
            List<int> fop1 = new List<int> { 17, };
            List<int> fop2 = new List<int> { 5, };
            List<int> fop3 = new List<int> { 22, };

            Rotor rotorOne = new Rotor("Rotor III", 0, fop1);
            Rotor rotorTwo = new Rotor("Rotor II", 9, fop2);
            Rotor rotorThree = new Rotor("Rotor I", 0, fop3);

            Reflector reflector = new Reflector("B");

            RotorGroup rg = new RotorGroup(rotorOne, rotorTwo, rotorThree, reflector);

            string expectedOut = "wkhlgbphfn";
            string enigmaOut = "";

            foreach (char c in "aaaaaaaaaa")
            {
                enigmaOut += rg.RotorEncrypt(c);
            }

            Assert.AreEqual(enigmaOut, expectedOut);
        }
    }

    [TestClass]
    public class EnigmaRotorFlipOver
    {
        [TestMethod]
        public void TestRotorOneFlipOverRotor1()
        {
            List<int> fop2 = new List<int> { 5, };


            Rotor r1 = new Rotor("Rotor II", 3, fop2);

            int offSet = r1.RotorOffset;

            Assert.AreEqual(r1.IterateOne(), false);
            Assert.AreEqual(r1.IterateOne(), true);
        }

        [TestMethod]
        public void TestRotorOneFlipOverRotor2()
        {
            List<int> fop1 = new List<int> { 17, };

            Rotor r1 = new Rotor("Rotor I", 15, fop1);

            int offSet = r1.RotorOffset;

            Assert.AreEqual(r1.IterateOne(), false);
            Assert.AreEqual(r1.IterateOne(), true);
        }

        [TestMethod]
        public void TestRotorOneFlipOverRotor3()
        {
            List<int> fop3 = new List<int> { 22, };

            Rotor r1 = new Rotor("Rotor III", 20, fop3);

            int offSet = r1.RotorOffset;

            Assert.AreEqual(r1.IterateOne(), false);
            Assert.AreEqual(r1.IterateOne(), true);
        }
    }

    [TestClass]
    public class TestLargerEncoding
    {
        [TestMethod]
        public void TestLargeEncoding1()
        {

        }
    }
}
