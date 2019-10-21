using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.UI;

namespace openlayerAPI.FamousPeoples
{
    public class FamousPeopleDomainService : DomainService
    {
        private readonly IRepository<FamousPeople, int> _famouspeopleRepository;

        public FamousPeopleDomainService(IRepository<FamousPeople,int> famouspeopleRepository)
        {
            _famouspeopleRepository = famouspeopleRepository;
        }

        public async Task<FamousPeople>GetFamousPeopleByName(string name)
        {
            var query = from f in _famouspeopleRepository.GetAll()
                        where f.Name == name
                        select f;

            var famouspeople = await query.FirstOrDefaultAsync();

            if (famouspeople == null)
            {
                throw new UserFriendlyException($"{name}不存在!");
            }
            return famouspeople;
        }
    }
}
