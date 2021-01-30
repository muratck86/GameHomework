using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    public abstract class BaseMemberService : IMemberService
    {
        public abstract void AddMember(BaseMember member);

        public void DeleteMember(BaseMember member)
        {
            Console.WriteLine("Memeber deleted...");
        }

        public void UpdateMember(BaseMember member)
        {
            throw new NotImplementedException();
        }
    }
}
