using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace openlayerAPI.Dynastys.Dto
{
    public class DynastyAppService : openlayerAPIAppServiceBase,IDynastyAppService
    {
        private readonly DynastyDomainService _dynastyDomainService;

        public DynastyAppService(DynastyDomainService dynastyDomainService)
        {
            _dynastyDomainService = dynastyDomainService;
        }

        public async Task<GetDynastyByDntOutput>GetDynastyByDnt(GetDynastyByDntInput input)
        {
            var item = await _dynastyDomainService.GetDynastyByDnt(input.Dnt);

            var output = ObjectMapper.Map<GetDynastyByDntOutput>(item);

            return output;
        }
    }
}
