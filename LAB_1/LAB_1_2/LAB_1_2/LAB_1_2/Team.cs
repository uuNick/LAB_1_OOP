
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_2
{
    class Team
    {
        private string _nameOfOrganization;
        private int _registerNumber;

        public Team(string orgName, int regNum)
        {
            _nameOfOrganization = orgName;
            _registerNumber = regNum;
        }

        public Team()
        {
            _nameOfOrganization = "No inf";
            _registerNumber = 0;
        }

        public string NameOfOrganization { get { return _nameOfOrganization; } set { _nameOfOrganization = value; } }

        public int RegistrationNumber
        {
            get { return _registerNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Registration number must be greater than 0.");
                }
                _registerNumber = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Team other = (Team)obj;
            return _nameOfOrganization == other._nameOfOrganization && RegistrationNumber == other.RegistrationNumber;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() / 2;
        }

        public static bool operator ==(Team left, Team right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(Team left, Team right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"Organization Name: {_nameOfOrganization}, Registration Number: {_registerNumber}";
        }
    }
}
