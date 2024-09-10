using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    class ResearchTeamCollection
    {
        private List<ResearchTeam> _lstResearchTeam;

        public delegate void TeamListHandler(object source, TeamListHandlerEventArgs args);

        public event TeamListHandler ResearchTeamAdded;
        public event TeamListHandler ResearchTeamInserted;

        public ResearchTeamCollection()
        {
            _lstResearchTeam = new List<ResearchTeam>();
        }

        public string NameOfCollection { get; set; }
        public List<ResearchTeam> LstResearchTeam { get { return _lstResearchTeam; } set { _lstResearchTeam = value; } }

        public void InsertAt(int j, ResearchTeam rt)
        {
            if ((j >= 0) && (j < _lstResearchTeam.Count))
            {
                _lstResearchTeam.Insert(j, rt);
                InsertInResearchTeam(rt, j);

            }
            else
            {
                _lstResearchTeam.Add(rt);
                AddInResearchTeam(rt, _lstResearchTeam.LastIndexOf(rt));

            }
        }

        public ResearchTeam this[int i]
        {
            get
            {
                if(i >= 0 && i < _lstResearchTeam.Count)
                {
                    return _lstResearchTeam[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (i > 0 && i < _lstResearchTeam.Count)
                {
                    _lstResearchTeam[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        
        public void Add(ResearchTeam ex)
        {
            _lstResearchTeam.Add(ex);
            AddInResearchTeam(ex, _lstResearchTeam.LastIndexOf(ex));
        }
        public void Add(params ResearchTeam[] lstOfResearches)
        {
            foreach(ResearchTeam researchTeam in lstOfResearches)
            {
                _lstResearchTeam.Add(researchTeam);
                AddInResearchTeam(researchTeam, _lstResearchTeam.LastIndexOf(researchTeam));
            }
        }
        void AddDefaults()
        {
            ResearchTeam ex_1 = new ResearchTeam("Organization 1", 10, "Winter", TimeFrame.Year);
            ResearchTeam ex_2 = new ResearchTeam("Organization 2", 11, "Summer", TimeFrame.Long);
            ResearchTeam ex_3 = new ResearchTeam("Organization 3", 12, "Spring", TimeFrame.TwoYears);
            _lstResearchTeam.Add(ex_1);
            AddInResearchTeam(ex_1, _lstResearchTeam.LastIndexOf(ex_1));
            _lstResearchTeam.Add(ex_2);
            AddInResearchTeam(ex_2, _lstResearchTeam.LastIndexOf(ex_2));
            _lstResearchTeam.Add(ex_3);
            AddInResearchTeam(ex_3, _lstResearchTeam.LastIndexOf(ex_3));
        }

        void AddResearchTeams(params ResearchTeam[] researchTeams)
        {
            foreach (ResearchTeam team in researchTeams)
            {
                _lstResearchTeam.Add(team);
                AddInResearchTeam(team, _lstResearchTeam.LastIndexOf(team));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var team in _lstResearchTeam)
            {
                sb.AppendLine($"Organization Name: {team.NameOfOrganization}");
                sb.AppendLine($"Research Topic: {team.NameOfResearch}");
                sb.AppendLine($"Registration Number: {team.RegistrationNumber}");
                sb.AppendLine($"Duration: {team.Duration}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public virtual string ToShortString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var team in _lstResearchTeam)
            {
                sb.AppendLine($"Organization Name: {team.NameOfOrganization}");
                sb.AppendLine($"Research Topic: {team.NameOfResearch}");
                sb.AppendLine($"Registration Number: {team.RegistrationNumber}");
                sb.AppendLine($"Duration: {team.Duration}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public void AddInResearchTeam(ResearchTeam team, int index)
        {
            ResearchTeamAdded?.Invoke(this, new TeamListHandlerEventArgs(this.NameOfCollection, "Add the elem at the end of collection", index));
        }
        public void InsertInResearchTeam(ResearchTeam team, int index)
        {
            ResearchTeamInserted?.Invoke(this, new TeamListHandlerEventArgs(this.NameOfCollection, "Insert element on " + index + "index", index));
        }
    }
}
