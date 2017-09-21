using System;
using NUnit.Framework;
using DoublyLinkedLists;

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class EmployeeTest
    {
        public EmployeeTest() { }

        /**
         * Sets up the test fixture.
         *
         * Called before every test case method.
         */
        [SetUp]
        public void setUp()
        {

        }

        /**
         * Tears down the test fixture.
         *
         * Called after every test case method.
         */
        [TearDown]
        public void tearDown()
        {

        }

        /// <summary>
        /// Test constructor for one argument
        /// </summary>
        [Test]
        public void testIDArgConstructor()
        {
            Employee emp = new Employee(0);
            Assert.That(emp, Is.Not.Null);
            Assert.That(emp.EmployeeID, Is.EqualTo(0));
            Assert.That(emp.EmployeeID, Is.Not.EqualTo(1));
            Assert.That(emp.FirstName, Is.Null);
            Assert.That(emp.LastName, Is.Null);

        }

        /// <summary>
        /// Test Constructor for all arguments
        /// </summary>
        [Test]
        public void testAllArgConstructor()
        {
            Employee emp = new Employee(1, "Maira", "Iantas");
            Assert.That(emp, Is.Not.Null);
            Assert.That(emp.EmployeeID, Is.EqualTo(1));
            Assert.That(emp.EmployeeID, Is.Not.EqualTo(0));
            Assert.That(emp.FirstName, Is.Not.Null);
            Assert.That(emp.LastName, Is.Not.Null);
        }

        /// <summary>
        /// Test compare to less than
        /// </summary>
        [Test]
        public void testCompareToFirstLower()
        {
            Employee emp1 = new Employee(500, "Byron"," Zebs");
            Employee emp2 = new Employee(1000, "Clarence", " Wishing");
            Assert.That(emp1.CompareTo(emp2), Is.LessThan(0));
        }

        /// <summary>
        /// Test compare to greather than
        /// </summary>
        [Test]
        public void testCompareToGreaterThan()
        {
            Employee emp1 = new Employee(1000, "Clarence", " Wishing");
            Employee emp2 = new Employee(500, "Byron", " Zebs");            
            Assert.That(emp1.CompareTo(emp2), Is.GreaterThan(0));
        }

        /// <summary>
        /// Test compare to equals to
        /// </summary>
        [Test]
        public void testCompareToEqualsTo()
        {
            Employee emp1 = new Employee(500, "Clarence", " Wishing");
            Employee emp2 = new Employee(500, "Byron", " Zebs");
            Assert.That(emp1.CompareTo(emp2), Is.EqualTo(0));
        }

        /// <summary>
        /// Test compare to equals to
        /// </summary>
        [Test]
        public void testCompareNotToEqualsTo()
        {
            Employee emp1 = new Employee(500, "Clarence", " Wishing");
            Employee emp2 = new Employee(3000, "Byron", " Zebs");
            Assert.That(emp1.CompareTo(emp2), Is.Not.EqualTo(0));
        }

        /// <summary>
        /// Test To String value
        /// </summary>
        [Test]
        public void testToStringValue()
        {
            Employee emp = new Employee(123, "Maira", "Iantas");
            Assert.That(emp.ToString(), Is.EqualTo("123 Maira Iantas"));


            Employee emp2 = new Employee(123);
            Assert.That(emp2.ToString(), Is.EqualTo("123  "));
        }

        /// <summary>
        /// Test To String value is null
        /// </summary>
        [Test]
        public void testToStringNull()
        {
            Employee emp = new Employee(123);
            Assert.That(emp.ToString(), Is.Not.Null);
        }

    }
}
