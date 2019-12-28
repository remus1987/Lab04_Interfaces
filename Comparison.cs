using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Interfaces
{
    class Comparison
    {
        public Comparison()
        {

        }
        public string Name { get; set; }

        #region CompareByName method
        public int CompareByName(string firstString, string secondString)
        {
            if (firstString != null && secondString != null)
            {
                return string.Compare(firstString, secondString);
            }
            else
            {
                return 10;
            }
            //Comparison c = (Comparison)o;
            //return String.Compare(this.Name, c.Name);
        }
        #endregion

        #region CompareByLength method
        public void CompareByLength(string firstString, string secondString)
        {
            if (firstString.Length > secondString.Length)
            {
                Console.Write("String One is longer.");
            }
            else if (firstString.Length < secondString.Length)
            {
                Console.Write("String Two is longer.");
            }
            else if (firstString.Length == secondString.Length)
            {
                Console.Write("Same Length");
            }
            else
            {
                Console.Write("One or both of the strings are null");
            }
        }
        #endregion

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
