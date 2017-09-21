using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedLists
{
    public class Node<T> : IComparable<T>
    {
        public static String STUDENT = "Maira Iantas, 0273129";

        /// <summary>
        /// Generic Data Property
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Previous Node
        /// </summary>
        public Node<T> Previous { get; set; }

        /// <summary>
        /// Next Node
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Node()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data"></param>
        public Node(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Constrcutor
        /// </summary>
        /// <param name="data"></param>
        /// <param name="previous"></param>
        /// <param name="next"></param>
        public Node(T data, Node<T> previous, Node<T> next) : this(data)
        {
            Data = data;
            Previous = previous;
            Next = next;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer 
        /// that indicates whether the current instance precedes, follows, or occurs in the same 
        /// position in the sort order as the other object.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
