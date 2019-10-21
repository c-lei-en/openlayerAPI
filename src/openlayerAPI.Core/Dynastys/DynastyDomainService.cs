using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.UI;

namespace openlayerAPI.Dynastys
{
    public class DynastyDomainService : DomainService
    {
        private readonly IRepository<Dynasty, int> _dynastyRepository;

        public DynastyDomainService(IRepository<Dynasty, int> dynastyRepository)
        {
            _dynastyRepository = dynastyRepository;
        }

        public async Task<Dynasty>GetDynastyByDnt(string name)
        {
            var query = from d in _dynastyRepository.GetAll()
                        where d.Dnt == name
                        select d;

            var dynasty = await query.FirstOrDefaultAsync();

            if (dynasty == null)
            {
                throw new UserFriendlyException($"{name}不存在!");
            }

            return dynasty;
        }
    }
}
