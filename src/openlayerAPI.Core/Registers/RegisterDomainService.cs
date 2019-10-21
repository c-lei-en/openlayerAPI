using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace openlayerAPI.Registers
{
    public class RegisterDomainService : DomainService
    {
        private readonly IRepository<Register, int> _userDomainService;

        public RegisterDomainService(IRepository<Register, int> userDomainService)
        {
            _userDomainService = userDomainService;
        }

        public async Task<bool>GetUserByName(string name,string password)
        {
            var query = from u in _userDomainService.GetAll()
                        where u.Name == name
                        select u;

            var user = await query.FirstOrDefaultAsync();

            if (user.Password == password && user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
