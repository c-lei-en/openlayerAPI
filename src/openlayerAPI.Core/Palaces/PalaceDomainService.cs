using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.UI;

namespace openlayerAPI.Palaces
{
    public class PalaceDomainService : DomainService
    {
        private readonly IRepository<Palace,int> _palaceRepository;

        public PalaceDomainService(IRepository<Palace, int> palaceRepository)
        {
            _palaceRepository = palaceRepository;
        }

        public async Task<Palace>GetPalaceByName(string name)
        {
            var query = from p in _palaceRepository.GetAll()
                        where p.Name == name
                        select p;

            var palace = await query.FirstOrDefaultAsync();

            if (palace == null)
            {
                throw new UserFriendlyException($"{name}不存在!");
            }
            return palace;
        }

    }
}
