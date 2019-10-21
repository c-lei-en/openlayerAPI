using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.Mountains.Dto
{
    public class MountainAppService : openlayerAPIAppServiceBase,IMountainAppService
    {
        private readonly MountainDomainService _mountainDomainService;
        
        public MountainAppService(MountainDomainService mountainDomainService)
        {
            _mountainDomainService = mountainDomainService;
        }

        public async Task<GetMountainByNameOutput>GetMountainByName(GetMountainByNameInput input)
        {
            var item = await _mountainDomainService.GetMountainByName(input.Name);

            var output = ObjectMapper.Map<GetMountainByNameOutput>(item);

            return output;
        }
    }
}
