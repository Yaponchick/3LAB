using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LAB.Tests
{
    [TestClass()]
    public class LengthTests
    {
        //1 Тест
        [TestMethod()]
        public void VerboseTest()
        {
            var length = new Length(10, 5);

            Assert.AreEqual("10/5", length.Verbose());
        }
        //2 Тест
        [TestMethod()]
        
        public void AddNumberTest()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 5);

            Length sum = length1 + length2;
            Assert.AreEqual("19/20", sum.Verbose());
        }
        //3 Тест
        [TestMethod()]

        public void AddNumberTest2()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 4);

            Length sum = length1 + length2;
            Assert.AreEqual("4/4", sum.Verbose());
        }
        //4 Тест
        [TestMethod()]
        public void Subtraction()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 5);

            Length subtraction = length1 - length2;
            Assert.AreEqual("11/20", subtraction.Verbose());
        }
        //5 Тест
        [TestMethod()]

        public void Subtraction2()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 4);

            Length subtraction = length1 - length2;
            Assert.AreEqual("2/4", subtraction.Verbose());
        }
        //6 Тест
        [TestMethod()]

        public void Multiplication()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 4);

            Length multiplication = length1 * length2;
            Assert.AreEqual("3/16", multiplication.Verbose());
        }
        //7 Тест
        [TestMethod()]
        public void Division()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 5);

            Length division = length1 / length2;
            Assert.AreEqual("15/4", division.Verbose());
        }
        //8 Тест
        [TestMethod()]
        public void Remains()
        {
            Length remains = new Length(1780, 500);
            remains.Remains();

            Assert.AreEqual("89/25", remains.Verbose());
        }
        //9 Тест
        [TestMethod()]
        public void Less()
        {
            Length length1 = new Length(10, 4);
            Length length2 = new Length(10, 2);

            string less = length1.To(length2);
/*            Assert.IsTrue(length1 < length2);
*/
            Assert.AreEqual("10/4 < 10/2", less);
        }
        //10 Тест
        [TestMethod()]
        public void More()
        {
            Length length1 = new Length(10, 2);
            Length length2 = new Length(10, 5);

            string more = length1.To(length2);
/*            Assert.IsTrue(length1 > length2);
*/
            Assert.AreEqual("10/2 > 10/5", more);
        }
    }
}