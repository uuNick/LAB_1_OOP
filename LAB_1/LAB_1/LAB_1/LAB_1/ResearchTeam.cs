using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LAB_1
{
    class ResearchTeam : Team
    {
        private string _nameOfResearch;
        private TimeFrame _duration;
        public ResearchTeam(string organizationName, int registrationNumber, string researchTopic, TimeFrame researchDuration)
        : base(organizationName, registrationNumber)
        {
            _nameOfResearch = researchTopic;
            _duration = researchDuration;
        }
        public ResearchTeam()
        {
            _nameOfResearch = "No inf";
            _duration = TimeFrame.Long;
        }
        public string NameOfResearch { get { return _nameOfResearch; } set { _nameOfResearch = value; } }
        public TimeFrame Duration { get { return _duration; } set { _duration = value; } }
        public Team Team
        {
            get { return new Team(NameOfOrganization, RegistrationNumber); }
            set
            {
                NameOfOrganization = value.NameOfOrganization;
                RegistrationNumber = value.RegistrationNumber;
            }
        }
        public bool this[TimeFrame key]
        {
            get
            {
                if (_duration == key)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return $"Research Topic: {_nameOfResearch}\nResearch Duration: {_duration}\n";
        }

        public virtual string ToShortString()
        {
            return $"Research Topic: {_nameOfResearch}\nName of organization: {NameOfOrganization}\n" +
                $"Registration number: {RegistrationNumber}\nDuration: {_duration}\n";
        }
    }
}
