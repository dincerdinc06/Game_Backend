using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Backend
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " Adlı Kampanya Başarıyla Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Başarıyla Güncellendi.");
        }
    }
}
