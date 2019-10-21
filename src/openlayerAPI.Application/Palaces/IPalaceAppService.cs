using Abp.Application.Services;
using openlayerAPI.Palaces.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.Palaces
{
    public interface IPalaceAppService : IApplicationService
    {
        Task<GetPalaceByNameOutput> GetPalaceByName(GetPalaceByNameInput input);
    }
}
