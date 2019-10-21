using Abp.Application.Services;
using openlayerAPI.Mountains.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.Mountains
{
    public interface IMountainAppService : IApplicationService
    {
        Task<GetMountainByNameOutput> GetMountainByName(GetMountainByNameInput input);
    }
}
