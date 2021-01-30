using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    public abstract class BaseMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public Membership MemberType { get; set; }

    }
}
