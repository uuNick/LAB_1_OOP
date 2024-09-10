using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_2
{

    public class ResearchTeamsChangedEventArgs<TKey> : EventArgs
    {
        public string CollectionName { get; }
        public Revision RevisionType { get; }
        public string ChangedProperty { get; }
        public int RegistrationNumber { get; }

        public ResearchTeamsChangedEventArgs(string collectionName, Revision revisionType, string changedProperty, int registrationNumber)
        {
            CollectionName = collectionName;
            RevisionType = revisionType;
            ChangedProperty = changedProperty;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return $"Collection: {CollectionName}, Revision: {RevisionType}, Changed Property: {ChangedProperty}, Reg. Number: {RegistrationNumber}";
        }
    }
}
