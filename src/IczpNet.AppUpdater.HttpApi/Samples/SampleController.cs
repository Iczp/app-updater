using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace IczpNet.AppUpdater.Samples;

[Area(AppUpdaterRemoteServiceConsts.ModuleName)]
[RemoteService(Name = AppUpdaterRemoteServiceConsts.RemoteServiceName)]
[Route("api/AppUpdater/sample")]
public class SampleController : AppUpdaterController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
