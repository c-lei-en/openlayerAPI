using openlayerAPI.Palaces.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.Palaces
{
    public class PalaceAppService : openlayerAPIAppServiceBase,IPalaceAppService
    {
        private readonly PalaceDomainService _palaceDomainService;
        public PalaceAppService(PalaceDomainService palaceDomainService)
        {
            _palaceDomainService = palaceDomainService;
        }

        public async Task<GetPalaceByNameOutput>GetPalaceByName(GetPalaceByNameInput input)
        {
            var item = await _palaceDomainService.GetPalaceByName(input.Name);

            var output = ObjectMapper.Map<GetPalaceByNameOutput>(item);

            return output;
        }
    }
}
