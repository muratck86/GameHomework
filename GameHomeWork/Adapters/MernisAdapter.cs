using GameHomeWork.Abstract;
using GameHomeWork.Entity;
using MernisCheckService;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Adapters
{
    public class MernisAdapter : ICheckMemberService
    {
        public bool CheckPerson(BaseMember member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(((NativeMember)member).NationalIdNo),
                member.Name, member.LastName, member.BirthDate.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
