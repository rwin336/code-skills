using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.craftinginterpreters.lox;

namespace com.craftinginterpreters.lox.test
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestParens()
        {
            Assert.IsFalse(Lox.scan("() (())"));
        }

        [TestMethod]
        public void TestBraces()
        {
            Assert.IsFalse(Lox.scan("{} {{}}"));
        }

        [TestMethod]
        public void TestCommas()
        {
            Assert.IsFalse(Lox.scan(",,,,,"));
        }

        [TestMethod]
        public void TestDots()
        {
            Assert.IsFalse(Lox.scan(".,.,...."));
        }

        [TestMethod]
        public void TestMinusSign()
        {
            Assert.IsFalse(Lox.scan("-----"));
        }

        [TestMethod]
        public void TestPlusSign()
        {
            Assert.IsFalse(Lox.scan("+++++"));
        }

        [TestMethod]
        public void TestSemiColon()
        {
            Assert.IsFalse(Lox.scan(";;;;;"));
        }

        [TestMethod]
        public void TestStar()
        {
            Assert.IsFalse(Lox.scan("*****"));
        }


        [TestMethod]
        public void TestNumberAssignmentStatement()
        {
            Assert.IsFalse(Lox.scan("var = 1234.56"));
        }

        [TestMethod]
        public void TestStringAssignmentStatement()
        {
            Assert.IsFalse(Lox.scan("var = \"Test string\""));
        }

        [TestMethod]
        public void TestQuotedString()
        {
            Assert.IsFalse(Lox.scan("\"This string is quoted properly\""));
        }

        [TestMethod]
        public void TestUnterminatedString()
        {
            Assert.IsTrue(Lox.scan("\"This string is not quoted properly"));
        }

        [TestMethod]
        public void TestUnterminatedStringAssignmentStatement()
        {
            Assert.IsTrue(Lox.scan("var = \"Test string"));
        }

        [TestMethod]
        public void TestCharMix()
        {
            Assert.IsFalse(Lox.scan("(*=-+{!=}==.)"));
        }

        [TestMethod]
        public void TestCharMixQuoted()
        {
            Assert.IsFalse(Lox.scan("\"(*=-+{!=}==.)\""));
        }

    }
}