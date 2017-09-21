using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedLists
{
    public class Employee : IComparable<Employee>
    {
        public static String STUDENT = "Maira Iantas, 0273129";

        /// <summary>
        /// Employee ID
        /// </summary>
        public int EmployeeID { get; }

        /// <summary>
        /// First Name
        /// </summary>
        public String FirstName { get; }

        /// <summary>
        /// Last Name
        /// </summary>
        public String LastName { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="employeeID"></param>
        public Employee(int employeeID)
        {
            this.EmployeeID = employeeID;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Employee(int employeeID, String firstName, String lastName) : this(employeeID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer 
        /// that indicates whether the current instance precedes, follows, or occurs in the same 
        /// position in the sort order as the other object.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Employee other)
        {
            return this.EmployeeID.CompareTo(other.EmployeeID);
        }

        /// <summary>
        ///  Returns a string that represents the current object.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => String.Format("{0} {1} {2}", EmployeeID, FirstName, LastName);

    }
}
