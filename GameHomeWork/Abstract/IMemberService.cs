using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    public interface IMemberService
    {
        void AddMember(BaseMember member);
        void UpdateMember(BaseMember member);
        void DeleteMember(BaseMember member);

    }
}
