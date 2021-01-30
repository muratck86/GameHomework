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
            IMemberService memberService = new NativeMemberService(new MernisAdapter());
            memberService.AddMember(new NativeMember { BirthDate = new DateTime(1986,7,12),
                Name = "Murat Can", LastName = "Kurt", NationalIdNo = "125"});
        }
    }
}
