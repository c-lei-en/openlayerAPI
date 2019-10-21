using Abp.Application.Services;
using openlayerAPI.Dynastys.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.Dynastys
{
    public interface IDynastyAppService : IApplicationService
    {
        Task<GetDynastyByDntOutput> GetDynastyByDnt(GetDynastyByDntInput input);
    }
}
