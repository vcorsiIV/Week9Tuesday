using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{

    /// <summary>
    /// Letter Class:
    /// Includes auto-implemented properties for the name of the
    /// recipient/client and the date mailed.
    /// Also includes a ToString() method that overrides the Object
    /// class's ToString() method and return a string that contains
    /// the name of the class (using GetType()) and the Letter data field value.
    /// Though as the child class is being called from the Main Class the GetType()
    /// will return the <MainClass_Name>.<ChildClass_Name>
    /// </summary>

    class Letter
    {
        private string clientName;
        protected string date;
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string FullDate
        {
            get { return date; }
            set { date = value; }
        }

        public override string ToString()
        {
            return (GetType() + ":\nRecipient: " + ClientName + "\nDate: " + FullDate + "\n");
        }
    }
}
