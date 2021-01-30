using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    public abstract class BaseCampaign
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
    }
}
