using AutoMapper;
using Bootstrap.AutoMapper;

namespace Redakcija.WinClient.Models
{
    public class ObjectMapper : IMapCreator
    {
        public void CreateMap(IProfileExpression mapper)
        {
            mapper.CreateMap<Clanak, WebServices.Clanak>();
            mapper.CreateMap<Publikacija, WebServices.Publikacija>();
            mapper.CreateMap<WebServices.Publikacija, Publikacija>();
            mapper.CreateMap<Rubrika, WebServices.Rubrika>();
            mapper.CreateMap<WebServices.Rubrika, Rubrika>();
        }

        public static WebServices.Clanak Map(Clanak clanak)
        {
            return Mapper.Map<WebServices.Clanak>(clanak);
        }

        public static Publikacija Map(WebServices.Publikacija publikacija)
        {
            return Mapper.Map<Publikacija>(publikacija);
        }
    }
}