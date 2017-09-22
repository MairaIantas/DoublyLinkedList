using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedLists
{
    public class Node<T> where T : IComparable<T>
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
    }
}
