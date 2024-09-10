using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_2
{
    class TeamsJournal
    {
        private List<TeamsJournalEntry> entries = new List<TeamsJournalEntry>();

        public void HandleResearchTeamsChanged(object source, ResearchTeamsChangedEventArgs<string> args)
        {
            var journalEntry = new TeamsJournalEntry(args.CollectionName, args.RevisionType, args.ChangedProperty, args.RegistrationNumber);
            entries.Add(journalEntry);
        }

        public void PropertyResearchTeamsChanged(object source, PropertyChangedEventArgs NameOfProperty)
        {
            var journalEntry = new TeamsJournalEntry("Undefined", Revision.Property, NameOfProperty.PropertyName, -1);
            entries.Add(journalEntry);
        }
        public override string ToString()
        {
            string result = "Teams Journal Entries:\n";
            foreach (var entry in entries)
            {
                result += entry.ToString() + "\n";
            }
            return result;
        }
    }
}
