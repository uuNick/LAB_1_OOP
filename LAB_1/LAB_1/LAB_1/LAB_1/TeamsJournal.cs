using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    class TeamsJournal
    {
        private List<TeamsJournalEntry> entries = new List<TeamsJournalEntry>();

        public void ResearchTeamAdded(object sender, TeamListHandlerEventArgs e)
        {
            TeamsJournalEntry entry = new TeamsJournalEntry(e.NameOfChangedCollection, "Team added", e.NumberOfElem);
            entries.Add(entry);
        }

        public void ResearchTeamlnserted(object sender, TeamListHandlerEventArgs e)
        {
            TeamsJournalEntry entry = new TeamsJournalEntry(e.NameOfChangedCollection, "Team Inserted", e.NumberOfElem);
            entries.Add(entry);
        }

        public override string ToString()
        {
            return String.Join(" ", entries);
        }
    }


}
