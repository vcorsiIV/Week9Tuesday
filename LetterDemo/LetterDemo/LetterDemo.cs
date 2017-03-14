using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LetterDemo
{
    class LetterDemo
    {
        /// <summary>
        /// LetterDemo:
        /// Declares the CertifiedLetter object and displays the properties and the 
        /// methods that will be used.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CertifiedLetter clientA = new CertifiedLetter();
            CertifiedLetter clientB = new CertifiedLetter();
            CertifiedLetter clientC = new CertifiedLetter();
            clientA.ClientName = "Alexander Bears";
            clientA.FullDate = "03/11/2017";
            clientA.TrackingNumber = 45120;
            clientB.ClientName = "Charles Danvers";
            clientB.FullDate = "11/09/2016";
            clientB.TrackingNumber = 44397;
            clientC.ClientName = "Edd Fredrick";
            clientC.FullDate = "01/31/2017";
            clientC.TrackingNumber = 44972;
            WriteLine("Letter Demo:\n");
            WriteLine(clientA.ToString() + "Tracking Number: " + clientA.TrackingNumber + "\n");
            WriteLine(clientB.ToString() + "Tracking Number: " + clientB.TrackingNumber + "\n");
            WriteLine(clientC.ToString() + "Tracking Number: " + clientC.TrackingNumber + "\n");
        }
    }
}
