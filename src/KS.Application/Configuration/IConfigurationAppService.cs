using System.Threading.Tasks;
using KS.Configuration.Dto;

namespace KS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
