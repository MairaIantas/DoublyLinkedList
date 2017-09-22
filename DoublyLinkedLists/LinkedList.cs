using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedLists
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public static String STUDENT = "Maira Iantas, 0273129";
        public const String EXCEPTION = "No such element";

        /// <summary>
        /// Points to the first node in the list 
        /// </summary>
        private Node<T> _head;

        /// <summary>
        /// Points to the last node in the list
        /// </summary>
        private Node<T> _tail;

        /// <summary>
        /// Count of the number of nodes in the list, zero when the list is empty.
        /// </summary>
        private int _size;

        /// <summary>
        /// Constructor
        /// </summary>
        public LinkedList() { }

        /// <summary>
        /// Add new data to the head of the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Boolean Add(T data)
        {
            linkHead(data);
            return true;
        }

        /// <summary>
        /// Add new data after the node containing the ‘oldData’ specified
        /// </summary>
        /// <param name="data"></param>
        /// <param name="oldData"></param>
        /// <returns></returns>
        public Boolean AddAfter(T data, T oldData) { return true; }

        /// <summary>
        /// Add new data after the node number specified
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public Boolean AddAfter(T data, int position) { return true; }

        /// <summary>
        /// Add new data after the node containing the ‘oldData’ specified
        /// </summary>
        /// <param name="data"></param>
        /// <param name="oldData"></param>
        /// <returns></returns>
        public Boolean AddBefore(T data, T oldData) { return true; }

        /// <summary>
        /// Add new data after the node number specified
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public Boolean AddBefore(T data, int position) { return true; }

        /// <summary>
        /// Add new data to the head of the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Boolean AddFirst(T data) { return true; }

        /// <summary>
        /// Add new data to the tail of the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Boolean AddLast(T data) { return true; }

        /// <summary>
        /// Empty all elements from the list
        /// </summary>
        public void Clear()
        {
            _head = _tail = null;
            _size = 0;
        }

        /// <summary>
        /// Return the data in the head node
        /// </summary>
        /// <returns></returns>
        public T Get()
        {
            if (_size <= 0)
            {
                throw new ApplicationException(EXCEPTION);
            }
            return _head.Data;
        }

        /// <summary>
        /// Return the data in the node containing the data specified
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T Get(T data) { return default(T); }

        /// <summary>
        /// Return the data in the node at the position number specified
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T Get(int position) { return default(T); }

        /// <summary>
        /// Return the data in the head node
        /// </summary>
        /// <returns></returns>
        public T GetFirst() { return default(T); }

        /// <summary>
        /// Return the data in the tail node
        /// </summary>
        /// <returns></returns>
        public T GetLast() { return default(T); }

        /// <summary>
        /// Return the count of the number of data elements (nodes) in the list
        /// </summary>
        /// <returns></returns>
        public int GetSize() { return _size; }

        /// <summary>
        /// Add the data specified into the proper location in the list based on natural ordering
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Boolean Insert(T data) { return true; }

        /// <summary>
        /// Returns a boolean to indicate if the linked list is empty or not. 
        /// True it is empty, false it is not empty
        /// </summary>
        /// <returns></returns>
        public Boolean IsEmpty()
        {
            return _size == 0;
        }

        /// <summary>
        /// Remove the head node
        /// </summary>
        /// <returns></returns>
        public T Remove()
        {
            if (_size <= 0)
            {
                throw new ApplicationException(EXCEPTION);
            }
            return unlinkHead();
        }

        /// <summary>
        /// Remove the node containing the data specified
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T Remove(T data) { return default(T); }

        /// <summary>
        /// Remove the node at the numeric position specified   
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T Remove(int position) { return default(T); }

        /// <summary>
        /// Remove the head node
        /// </summary>
        /// <returns></returns>
        public T RemoveFirst() { return default(T); }

        /// <summary>
        /// Remove the tail node
        /// </summary>
        /// <returns></returns>
        public T RemoveLast() { return default(T); }

        /// <summary>
        /// Change the data on the head node with the data specified 
        /// and return the old data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T Set(T data)
        {
            if (_size <= 0)
            {
                throw new ApplicationException(EXCEPTION);
            }
            return setData(data, _head); ;
        }

        /// <summary>
        /// Change the data on the node containing the old
        /// data with the data passed and return the old data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="oldData"></param>
        /// <returns></returns>
        public T Set(T data, T oldData) { return default(T); }

        /// <summary>
        /// Change the data on the head node with the data 
        /// specified and return the old data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T SetFirst(T data) { return default(T); }

        /// <summary>
        /// Change the data on the tail node with the data 
        /// specified and return the old data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public T SetLast(T data) { return default(T); }

        /// <summary>
        /// Find and return the node with the numeric position specified
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private Node<T> find(int position) { return new Node<T>(); }

        /// <summary>
        /// Find and return the node containing the data specified
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Node<T> find(T data) { return new Node<T>(); }

        /// <summary>
        /// Add a new node at the head of the linked list
        /// </summary>
        /// <param name="element"></param>
        private void linkHead(T data)
        {
            Node<T> toAdd = new Node<T>(data);

            if (_head != null)
            {
                _head.Previous = toAdd;
                toAdd.Next = _head;

            }

            _head = toAdd;

            if (_size == 0)
            {
                _tail = _head;
            }
            _size++;
        }

        /// <summary>
        /// Add a new node at the tail of the list
        /// </summary>
        /// <param name="data"></param>
        private void linkTail(T data) { }

        /// <summary>
        /// Add a new node containing the data passed between the previous and next nodes
        /// </summary>
        /// <param name="data"></param>
        /// <param name="previous"></param>
        /// <param name="next"></param>
        private void link(T data, Node<T> previous, Node<T> next) { }

        /// <summary>
        /// Change the data stored on the node, return the old node data
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        private T setData(T newData, Node<T> node)
        {
            T oldData = node.Data;
            node.Data = newData;
            return oldData;
        }

        /// <summary>
        /// Remove node from the linked list
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        private T unlink(T node) { return node; }

        /// <summary>
        /// Remove the head node from the linked list
        /// </summary>
        /// <returns></returns>
        private T unlinkHead()
        {
            Node<T> oldHead = _head;
            _head = _head.Next;
            _size--;

            if (_head == null)
            {
                _tail = null;
            }
            else
            {
                _head.Previous = null;
            }

            return oldHead.Data;
        }

        /// <summary>
        /// Remove the tail node from the linked list
        /// </summary>
        /// <returns></returns>
        private T unlinkTail() { return default(T); }

        /// <summary>
        /// Ensure the position specified is in
        /// the bounds of the linked list
        /// </summary>
        /// <param name="position"></param>
        private void validatePosition(int position) { }
    }
}
