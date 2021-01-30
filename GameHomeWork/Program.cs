using GameHomeWork.Abstract;
using GameHomeWork.Adapters;
using GameHomeWork.Concrete;
using GameHomeWork.Entity;
using System;

namespace GameHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemberService nativeMemberService = new NativeMemberService(new MernisAdapter());
            nativeMemberService.AddMember(new NativeMember
            {
                BirthDate = new DateTime(1986, 7, 12),
                Name = "Murat Can",
                LastName = "Kurt",
                NationalIdNo = "125"
            });
            IMemberService foreignerMemberService = new ForeignerMemberService(new ConfirmationCodeAdapter());
            foreignerMemberService.AddMember(new ForeignerMember
            {
                Name = "Henry",
                LastName = "Brown",
                Nationality = "UK",
                BirthDate = new DateTime(1988, 6, 5),
                PhoneNumber = "5322221010"
            });
        }
    }
}
