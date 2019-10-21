using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.FamousPeoples.Dto
{
    public class FamousPeopleAppService : openlayerAPIAppServiceBase,IFamousPeopleAppService
    {
        private readonly FamousPeopleDomainService _famouspeopleDomainService;

        public FamousPeopleAppService(FamousPeopleDomainService famouspeopleDomainService)
        {
            _famouspeopleDomainService = famouspeopleDomainService;
        }

        public async Task<GetFamousPeopleByNameOutput>GetFamousPeopleByName(GetFamousPeopleByNameInput input)
        {
            var item = await _famouspeopleDomainService.GetFamousPeopleByName(input.Name);

            var output = ObjectMapper.Map<GetFamousPeopleByNameOutput>(item);

            return output;
        }
    }
}
