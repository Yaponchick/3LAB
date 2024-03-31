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
        //Ситуация - Проверка вывода дроби
        [TestMethod()]
        public void VerboseTest()
        {
            var length = new Length(10, 5);

            Assert.AreEqual("10/5", length.Verbose());
        }
        //2 Тест
        //Ситуация - Проверка сложения дроби с разными знаменателями 
        [TestMethod()]
        
        public void AddNumberTest()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 5);

            Length sum = length1 + length2;
            Assert.AreEqual("19/20", sum.Verbose());
        }
        //3 Тест
        //Ситуация - Проверка сложения дроби с одинаковыми знаменателями
        [TestMethod()]

        public void AddNumberTest2()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 4);

            Length sum = length1 + length2;
            Assert.AreEqual("4/4", sum.Verbose());
        }
        //4 Тест
        //Ситуация - Проверка вычитания дроби с разными знаменателями 
        [TestMethod()]
        public void Subtraction()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 5);

            Length subtraction = length1 - length2;
            Assert.AreEqual("11/20", subtraction.Verbose());
        }
        //5 Тест
        //Ситуация - Проверка вычиатния дроби с одинаковыми знаменателями
        [TestMethod()]

        public void Subtraction2()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 4);

            Length subtraction = length1 - length2;
            Assert.AreEqual("2/4", subtraction.Verbose());
        }
        //6 Тест
        //Ситуация - Проверка умножения дроби
        [TestMethod()]

        public void Multiplication()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 4);

            Length multiplication = length1 * length2;
            Assert.AreEqual("3/16", multiplication.Verbose());
        }
        //7 Тест
        //Ситуация - Проверка деления дроби
        [TestMethod()]
        public void Division()
        {
            Length length1 = new Length(3, 4);
            Length length2 = new Length(1, 5);

            Length division = length1 / length2;
            Assert.AreEqual("15/4", division.Verbose());
        }
        //8 Тест
        //Ситуация - Проверка сокращения дроби
        [TestMethod()]
        public void Remains()
        {
            Length remains = new Length(1780, 500);
            remains.Remains();

            Assert.AreEqual("89/25", remains.Verbose());
        }
        //9 Тест
        //Ситуация - Проверка сравнения дроби (Вторая дробь больше)
        [TestMethod()]
        public void Less()
        {
            Length length1 = new Length(10, 4);
            Length length2 = new Length(10, 2);

            string less = length1.To(length2);

            Assert.AreEqual("10/4 < 10/2", less);
        }
        //10 Тест
        //Ситуация - Проверка сравнения дроби (Первая дробь больше)
        [TestMethod()]
        public void More()
        {
            Length length1 = new Length(10, 2);
            Length length2 = new Length(10, 5);

            string more = length1.To(length2);

            Assert.AreEqual("10/2 > 10/5", more);
        }
    }
}