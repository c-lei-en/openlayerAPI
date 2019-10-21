using System.Threading.Tasks;
using openlayerAPI.Configuration.Dto;

namespace openlayerAPI.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
