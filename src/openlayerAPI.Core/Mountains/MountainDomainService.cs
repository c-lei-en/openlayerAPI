using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace openlayerAPI.Mountains
{
    public class MountainDomainService : DomainService
    {
        private readonly IRepository<Mountain, int> _mountainDomainService;

        public MountainDomainService(IRepository<Mountain,int> mountainDomainService)
        {
            _mountainDomainService = mountainDomainService;
        }

        public async Task<Mountain>GetMountainByName(string name)
        {
            var query = from m in _mountainDomainService.GetAll()
                        where m.Name == name
                        select m;
            var mountain = await query.FirstOrDefaultAsync();
            if (mountain == null)
            {
                throw new UserFriendlyException($"{name}不存在！");
            }

            return mountain;
        }
    }
}
