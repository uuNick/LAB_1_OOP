﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_2
{
    class TeamListHandlerEventArgs: EventArgs
    {
        public TeamListHandlerEventArgs(string nameOfChangedCollection, string typeOfChange, int numOfElem)
        {
            NameOfChangedCollection = nameOfChangedCollection;
            TypeOfChange = typeOfChange;
            NumberOfElem = numOfElem;
        }
        
        public TeamListHandlerEventArgs() 
        {

        }

        public string NameOfChangedCollection { get; set; }
        public string TypeOfChange {  get; set; }
        public int NumberOfElem { get; set; }

        public override string ToString()
        {
            return "Name of changed collection: " + NameOfChangedCollection + "\nType of change: " + TypeOfChange + "\nNumber of Element: " + NumberOfElem; 
        }
    }
}
