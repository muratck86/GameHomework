using GameHomeWork.Abstract;
using GameHomeWork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    public class CampaignService
    {
        public void ApplyCampaign(FreeItemCampaign campaign)
        {
            Console.WriteLine("User inventory updated, new item added...");
        }

        public void ApplyCampaign(BaseMember member, DiscountCampaign campaign, Membership membership)
        {
            Console.WriteLine("membership upgraded...");
            member.MemberType = membership;
        }
    }
}
