using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Interfaces
{
    public interface ICampaignRepository
    {
        Campaign AddCampaign(Campaign campaign);
        Campaign FindByName(string name);
        IList<Campaign> FindActiveCampaigns();
        Campaign UpdateCampaign(Campaign campaign);
    }
}
