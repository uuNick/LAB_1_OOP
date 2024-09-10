using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;

namespace LAB_1_2
{
    class ResearchTeam : Team, INotifyPropertyChanged
    {
        private string _nameOfResearch;
        private TimeFrame _duration;
        public ResearchTeam(string organizationName, int registrationNumber, string researchTopic, TimeFrame researchDuration)
        : base(organizationName, registrationNumber)
        {
            _nameOfResearch = researchTopic;
            _duration = researchDuration;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ResearchTeam()
        {
            _nameOfResearch = "No inf";
            _duration = TimeFrame.Long;
        }
        public string NameOfResearch { get { return _nameOfResearch; } set { _nameOfResearch = value; OnPropertyChanged("NameOfResearch"); } }
        public TimeFrame Duration { get { return _duration; } set { _duration = value; OnPropertyChanged("Duration"); } }

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
