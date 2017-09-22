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
            LinkedList<Employee> listNode = new LinkedList<Employee>();

            Assert.That(listNode, Is.Not.Null);
        }

        /// <summary>
        /// Test add node to the list
        /// </summary>
        [Test]
        public void testAddNodeIntoEmptyList()
        {
            Employee empNode = new Employee(0);
            LinkedList<Employee> listNode = new LinkedList<Employee>();

            Assert.That(listNode.Add(empNode), Is.True);
        }

        /// <summary>
        /// Test get node to the list
        /// </summary>
        [Test]
        public void testGetEmptyList()
        {
            Employee empNode = new Employee(0);
            LinkedList<Employee> listNode = new LinkedList<Employee>();
            listNode.Add(empNode);

            Assert.That(listNode.Get(), Is.EqualTo(empNode));
        }

        /// <summary>
        /// Test get Exception
        /// </summary>
        [Test]
        public void testGetEmptyListException()
        {
            LinkedList<Employee> listNode = new LinkedList<Employee>();

            Assert.That(() => listNode.Get(), Throws.Exception.TypeOf<ApplicationException>());
        }

        /// <summary>
        /// Test set node to the list
        /// </summary>
        [Test]
        public void testSetNodesIntoList()
        {
            Employee empNode = new Employee(0);
            Employee empNode1 = new Employee(1);
            LinkedList<Employee> listNode = new LinkedList<Employee>();

            listNode.Add(empNode);

            Assert.That(listNode.Set(empNode1), Is.EqualTo(empNode));
            Assert.That(listNode.Get(), Is.EqualTo(empNode1));
        }

        /// <summary>
        /// Test set Exception
        /// </summary>
        [Test]
        public void testSetNodeIntoEmptyListException()
        {
            LinkedList<Employee> listNode = new LinkedList<Employee>();
            Assert.That(() => listNode.Set(new Employee(0)), Throws.Exception.TypeOf<ApplicationException>());
        }

        /// <summary>
        /// Test remove
        /// </summary>
        [Test]
        public void testRemoveNodeInEmptyList()
        {
            Employee empNode = new Employee(0);
            LinkedList<Employee> listNode = new LinkedList<Employee>();
            listNode.Add(empNode);

            Assert.That(listNode.Remove(), Is.EqualTo(empNode));
        }

        /// <summary>
        /// Test get Exception
        /// </summary>
        [Test]
        public void testRemoveNodeInEmptyListException()
        {
            LinkedList<Employee> listNode = new LinkedList<Employee>();

            Assert.That(() => listNode.Remove(), Throws.Exception.TypeOf<ApplicationException>());
        }

        /// <summary>
        /// Test Get Size
        /// </summary>
        [Test]
        public void testGetSizeList()
        {
            Employee empNode = new Employee(0);
            LinkedList<Employee> listNode = new LinkedList<Employee>();
            listNode.Add(empNode);

            Assert.That(listNode.GetSize, Is.Not.Zero);
        }

        /// <summary>
        /// Test Get Size
        /// </summary>
        [Test]
        public void testGetSizeEqualsToZero()
        {
            LinkedList<Employee> listNode = new LinkedList<Employee>();

            Assert.That(listNode.GetSize, Is.Zero);
        }

        /// <summary>
        /// Test if it is empty
        /// </summary>
        [Test]
        public void testIsEmptyList()
        {
            LinkedList<Employee> listNode = new LinkedList<Employee>();

            Assert.That(listNode.IsEmpty, Is.True);

            Employee empNode = new Employee(0);

            listNode.Add(empNode);

            Assert.That(listNode.IsEmpty, Is.False);
        }

        /// <summary>
        /// Test Clear
        /// </summary>
        [Test]
        public void testClear()
        {
            LinkedList<Employee> listNode = new LinkedList<Employee>();
            Employee empNode = new Employee(0);
            listNode.Add(empNode);

            Assert.That(listNode.IsEmpty, Is.False);

            listNode.Clear();

            Assert.That(listNode.GetSize, Is.Zero);
        }
    }
}
