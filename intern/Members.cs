using System;
using System.Collections.Generic;
using System.Text;

namespace intern
{
    class Members
    {
        int MemberId;
        string FirstName;
        string LastName;

        public Members()
        {

        }
        public int memberId
        {
            get { return MemberId; }
            set { MemberId = value; }
        }
        public string firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
