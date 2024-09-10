using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    class TeamsJournalEntry
    {
        public string NameOfChangedCollection { get; set; }
        public string NameOfEvent { get; set; }
        public int NumberOfNewElem { get; set; }

        public TeamsJournalEntry(string nameOfChangedCollection, string nameOfEvent, int numOfNewElem) 
        {
            NameOfChangedCollection = nameOfChangedCollection;
            NameOfEvent = nameOfEvent;
            NumberOfNewElem = numOfNewElem;
        }

        public TeamsJournalEntry()
        {
            NameOfChangedCollection = "N\\A";
            NameOfEvent = "N\\A";
            NumberOfNewElem = -1;
        }

        public override string ToString() 
        {
            return "Name of collection: " + NameOfChangedCollection + "\nType of change: " + NameOfEvent + "\nIndex of element: " + NumberOfNewElem + "\n\n";
        }


    }
}
