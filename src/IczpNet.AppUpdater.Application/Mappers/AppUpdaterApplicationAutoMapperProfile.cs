using AutoMapper;
using IczpNet.AppUpdater.AppClients;
/*---------code-generator-namespace: Do not modify or delete this line of comments--------*/

namespace IczpNet.AppUpdater.Mappers;

public class AppUpdaterApplicationAutoMapperProfile : Profile
{
    public AppUpdaterApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


        
        //AppClient
        CreateMap<AppClient, AppClientDto>();
        CreateMap<AppClient, AppClientSampleDto>();
        CreateMap<AppClient, AppClientDetailDto>();
        CreateMap<AppClientCreateInput, AppClient>(MemberList.Source).IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        CreateMap<AppClientUpdateInput, AppClient>(MemberList.Source).IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        

        /*---------code-generator-mapper: Do not modify or delete this line of comments--------*/
    }
}
