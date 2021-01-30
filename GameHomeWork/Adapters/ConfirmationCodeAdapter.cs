using GameHomeWork.Abstract;
using GameHomeWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Adapters 
{
    public class ConfirmationCodeAdapter : ICheckMemberService
    {
        public bool CheckPerson(BaseMember member)
        {
            return (((ForeignerMember)member).PhoneNumber.Length == 10);
        }
    }
}
