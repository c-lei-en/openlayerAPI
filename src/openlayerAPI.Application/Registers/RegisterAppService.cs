using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace openlayerAPI.Registers.Dto
{
    public class RegisterAppService : openlayerAPIAppServiceBase
    {
        private readonly RegisterDomainService _userDomainService;
        public RegisterAppService(RegisterDomainService userDomainService)
        {
            _userDomainService = userDomainService;
        }

        public async Task<bool>GetUserByName(GetRegisterByNameInput input)
        {
            var item = await _userDomainService.GetUserByName(input.Name,input.Password);
            return item;
        }
    }
}
