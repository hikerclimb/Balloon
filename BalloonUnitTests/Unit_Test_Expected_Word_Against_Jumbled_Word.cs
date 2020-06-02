using Microsoft.VisualStudio.TestTools.UnitTesting;
using Balloon;
using System.Collections.Generic;

namespace BalloonUnitTests
{
    [TestClass]
    public class Unit_Test_Expected_Word_Against_Jumbled_Word
    {
        [TestMethod]
        public void Expected_1_Word_Balloon_In_String()
        {
            string expected_Word = "BALLOON";
            string jumbled_Word = "BLONDGALO";

            Program b = new Program();
            int count = b.number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(expected_Word, jumbled_Word);

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Expected_0_Word_Balloon_In_String()
        {
            string expected_Word = "BALLOON";
            string jumbled_Word = "BLONDGAO";

            Program b = new Program();
            int count = b.number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(expected_Word, jumbled_Word);

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Expected_2_Word_Balloon_In_String()
        {
            string expected_Word = "BALLOON";
            string jumbled_Word = "BLONDGALOBLLOOAN";

            Program b = new Program();
            int count = b.number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(expected_Word, jumbled_Word);

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Expected_1_Word_Balloon_In_String_With_Additional_Letters_In_String()
        {
            string expected_Word = "BALLOON";
            string jumbled_Word = "LONDGALOOONKB";

            Program b = new Program();
            int count = b.number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(expected_Word, jumbled_Word);

            Assert.AreEqual(count, 1);
        }

        [TestMethod]
        public void Expected_1_Word_Balloon_In_String_With_Additonal_Letters()
        {
            string expected_Word = "BALLOON";
            string jumbled_Word = "BLONDGALONNN";

            Program b = new Program();
            int count = b.number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(expected_Word, jumbled_Word);

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void Expected_3_Word_Balloon()
        {
            string expected_Word = "BALLOON";
            string jumbled_Word = "BLONDGALOBALLOONNBALLOON";

            Program b = new Program();
            int count = b.number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(expected_Word, jumbled_Word);

            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void Expected_0_Word_Balloon()
        {
            string expected_Word = "BALLOON";
            string jumbled_Word = "M";

            Program b = new Program();
            int count = b.number_Of_Times_Jumbled_Word_Occurs_In_Expected_Word(expected_Word, jumbled_Word);

            Assert.AreEqual(0, count);
        }
    }
}
