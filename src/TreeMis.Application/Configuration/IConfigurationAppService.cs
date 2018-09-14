using System.Threading.Tasks;
using TreeMis.Configuration.Dto;

namespace TreeMis.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
