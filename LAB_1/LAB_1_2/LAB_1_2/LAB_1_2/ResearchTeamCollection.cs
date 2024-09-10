using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LAB_1_2
{
    class ResearchTeamCollection<Tkey>
    {
        private Dictionary<Tkey, ResearchTeam> teamsDictionary = new Dictionary<Tkey, ResearchTeam>();

        public string CollectionName { get; set; }

        public delegate void ResearchTeamsChangedHandler<TKey>(object source, ResearchTeamsChangedEventArgs<TKey> e);
        
        public event ResearchTeamsChangedHandler<Tkey> ResearchTeamsChanged;

        public void Add(Tkey key, ResearchTeam team)
        {
            teamsDictionary.Add(key, team);
            OnResearchTeamsChanged(new ResearchTeamsChangedEventArgs<Tkey>(CollectionName, Revision.Add, "", team.RegistrationNumber));
        }

        public bool Remove(ResearchTeam rt)
        {
            Tkey keyToRemove = default(Tkey); //Значение по умолчанию
            foreach (var pair in teamsDictionary)
            {
                if (pair.Value == rt)
                {
                    keyToRemove = pair.Key;
                    break;
                }
            }

            if (keyToRemove != null)
            {
                teamsDictionary.Remove(keyToRemove);
                OnResearchTeamsChanged(new ResearchTeamsChangedEventArgs<Tkey>(CollectionName, Revision.Remove, "", rt.RegistrationNumber));
                return true;
            }

            return false;
        }

        public bool Replace(ResearchTeam rtOld, ResearchTeam rtNew)
        {
            Tkey keyToReplace = default(Tkey);
            foreach (var pair in teamsDictionary)
            {
                if (pair.Value == rtOld)
                {
                    keyToReplace = pair.Key;
                    break;
                }
            }

            if (keyToReplace != null)
            {
                teamsDictionary[keyToReplace] = rtNew;
                OnResearchTeamsChanged(new ResearchTeamsChangedEventArgs<Tkey>(CollectionName, Revision.Replace, "", rtNew.RegistrationNumber));
                return true;
            }

            return false;
        }

        public void OnResearchTeamsChanged(ResearchTeamsChangedEventArgs<Tkey> args)
        {
            ResearchTeamsChanged?.Invoke(this, args);
        }

    }
}
