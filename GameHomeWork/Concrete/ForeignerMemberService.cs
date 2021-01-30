using GameHomeWork.Abstract;
using GameHomeWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    public class ForeignerMemberService : BaseMemberService
    {
        private ICheckMemberService _checkMember;

        public ForeignerMemberService(ICheckMemberService checkMember)
        {
            _checkMember = checkMember;
        }
        public override void AddMember(BaseMember member)
        {
            if(_checkMember.CheckPerson(member))
                Console.WriteLine("foreigner add member");
            else
                Console.WriteLine("Error: member validation");
        }
    }
}
