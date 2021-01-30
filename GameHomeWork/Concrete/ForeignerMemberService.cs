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

        public bool CheckPerson(ForeignerMember member)
        {
            Console.WriteLine("Please enter the confirmation code sent to your phone number...");
            return true;
        }
    }
}
