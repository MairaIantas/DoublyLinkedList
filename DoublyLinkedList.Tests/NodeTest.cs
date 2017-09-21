using System;
using NUnit.Framework;
using DoublyLinkedLists;

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class NodeTest
    {
        public NodeTest() { }

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
        /// Test constructor for none argument
        /// </summary>
        [Test]
        public void testNoArgConstructor()
        {
            Node<Employee> empNode = new Node<Employee>();
            Assert.That(empNode, Is.Not.Null);
        }

        /// <summary>
        /// Test constructor for one argument
        /// </summary>
        [Test]
        public void testOneArgConstructor()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(0));
            Assert.That(empNode, Is.Not.Null);
        }

        /// <summary>
        /// Test Constructor for all arguments
        /// </summary>
        [Test]
        public void testAllArgConstructor()
        {
            Node<Employee> empNode0 = new Node<Employee>(new Employee(0));
            Node<Employee> empNode1 = new Node<Employee>(new Employee(1));
            Node<Employee> empNode2 = new Node<Employee>(new Employee(2), empNode0, empNode1);

            Assert.That(empNode2.Data, Is.Not.Null);
        }

        /// <summary>
        /// Test Previous getters and setters
        /// </summary>
        [Test]
        public void testData()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(1));    

            Assert.That(empNode.Data, Is.Not.Null);
            Assert.That(empNode.Data.EmployeeID, Is.EqualTo(1));

        }

        /// <summary>
        /// Test Previous getters and setters
        /// </summary>
        [Test]
        public void testPrevious()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(1));
            empNode.Previous = new Node<Employee>(new Employee(0));           

            Assert.That(empNode.Previous, Is.Not.Null);
            Assert.That(empNode.Previous.Data.EmployeeID, Is.EqualTo(0));

        }

        /// <summary>
        /// Test Previous getters and setters
        /// </summary>
        [Test]
        public void testNext()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(1));
            empNode.Next = new Node<Employee>(new Employee(2));

            Assert.That(empNode.Next, Is.Not.Null);
            Assert.That(empNode.Next.Data.EmployeeID, Is.EqualTo(2));

        }

        /// <summary>
        /// Test the NotImplementedException message
        /// </summary>
        [Test]
        public void testExceptionExpectedLambda()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(0));
            Employee empNode1 = new Employee(1);

            Assert.That(() => empNode.CompareTo(empNode1), Throws.Exception.TypeOf<NotImplementedException>());
        }

    }
}
