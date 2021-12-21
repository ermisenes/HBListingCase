using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Interfaces;

namespace Data.EntitiyFrameWork
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly HepsiBuradaDbContext _context;

        public CampaignRepository(HepsiBuradaDbContext context)
        {
            _context = context;
        }

        public Campaign AddCampaign(Campaign campaign)
        {
            _context.Campaigns.Add(campaign);
            _context.SaveChanges();
            return campaign;
        }

        public IList<Campaign> FindActiveCampaigns()
        {
            return _context.Campaigns.Where(x => x.Active && x.Duration > 0 && x.EndDate >= DateTime.Now).ToList();
        }

        public Campaign FindByName(string name)
        {
            return _context.Campaigns.FirstOrDefault(x => x.Name.ToLower().Contains(name.ToLower()) && x.Active);
        }

        public Campaign UpdateCampaign(Campaign campaign)
        {
            _context.Campaigns.Update(campaign);
            _context.SaveChanges();
            return campaign;
        }
    }
}
