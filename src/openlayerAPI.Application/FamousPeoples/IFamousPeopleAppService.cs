using Abp.Application.Services;
using openlayerAPI.FamousPeoples.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.FamousPeoples
{
    public interface IFamousPeopleAppService : IApplicationService
    {
        Task<GetFamousPeopleByNameOutput> GetFamousPeopleByName(GetFamousPeopleByNameInput input);
    }
}
