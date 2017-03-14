using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{
    /// <summary>
    /// LetterDemo:
    /// Child Class of the Letter Class.
    /// Includes an auto-implemented property that
    /// holds a tracking number for the letter.
    /// </summary>
    class CertifiedLetter : Letter
    {
        private int trackingNumber;
        public int TrackingNumber
        {
            get { return trackingNumber; }
            set { trackingNumber = value; }
        }
    }
}
