using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICampaignService
    {
        string CreateCampaign(string[] commandLine);
        string GetCampaignInfo(string[] commandLine);
        void FinishedCampaign();
        bool IsExistActiveCampaign();
    }
}
