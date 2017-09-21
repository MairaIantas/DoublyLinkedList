using System;
using NUnit.Framework;
using DoublyLinkedLists;

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class LinkedListTest
    {
        public LinkedListTest() { }

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
        public void testNoArgConstructor()
        {
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();

            Assert.That(listNode, Is.Not.Null);
        }

        /// <summary>
        /// Test add node to the list
        /// </summary>
        [Test]
        public void testAdd()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(0));
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();

            Assert.That(listNode.Add(empNode), Is.True);
        }

        /// <summary>
        /// Test get node to the list
        /// </summary>
        [Test]
        public void testGet()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(0));
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();
            listNode.Add(empNode);

            Assert.That(listNode.Get(), Is.EqualTo(empNode));
        }

        /// <summary>
        /// Test get Exception
        /// </summary>
        [Test]
        public void testGetException()
        {
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();

            Assert.That(() => listNode.Get(), Throws.Exception.TypeOf<ApplicationException>());
        }

        /// <summary>
        /// Test remove
        /// </summary>
        [Test]
        public void tesRemove()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(0));
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();
            listNode.Add(empNode);

            Assert.That(listNode.Remove(), Is.EqualTo(empNode));
        }

        /// <summary>
        /// Test get Exception
        /// </summary>
        [Test]
        public void testRemoveException()
        {
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();

            Assert.That(() => listNode.Remove(), Throws.Exception.TypeOf<ApplicationException>());
        }

        /// <summary>
        /// Test Get Size
        /// </summary>
        [Test]
        public void testGetSize()
        {
            Node<Employee> empNode = new Node<Employee>(new Employee(0));
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();
            listNode.Add(empNode);

            Assert.That(listNode.GetSize, Is.Not.Zero);
        }

        /// <summary>
        /// Test Get Size
        /// </summary>
        [Test]
        public void testGetSizeEqualsToZero()
        {
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();

            Assert.That(listNode.GetSize, Is.Zero);
        }

        // <summary>
        /// Test is empty
        /// </summary>
        [Test]
        public void testIsEmpty()
        {
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();

            Assert.That(listNode.IsEmpty, Is.True);

            Node<Employee> empNode = new Node<Employee>(new Employee(0));

            listNode.Add(empNode);

            Assert.That(listNode.IsEmpty, Is.False);
        }

        // <summary>
        /// Test Clear
        /// </summary>
        [Test]
        public void testClear()
        {
            LinkedList<Node<Employee>> listNode = new LinkedList<Node<Employee>>();
            Node<Employee> empNode = new Node<Employee>(new Employee(0));
            listNode.Add(empNode);

            Assert.That(listNode.IsEmpty, Is.False);

            listNode.Clear();

            Assert.That(listNode.GetSize , Is.Zero);
        }
    }
}
