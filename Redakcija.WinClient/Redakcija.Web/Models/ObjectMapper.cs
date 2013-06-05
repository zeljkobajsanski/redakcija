using AutoMapper;
using Bootstrap.AutoMapper;

namespace Redakcija.Web.Models
{
    public class ObjectMapper : IMapCreator
    {
        public void CreateMap(IProfileExpression mapper)
        {
            mapper.CreateMap<Model.Entities.Publikacija, Publikacija>();
            mapper.CreateMap<Model.Entities.Rubrika, Rubrika>();
        }

        public static Publikacija Map(Model.Entities.Publikacija publikacija)
        {
            return Mapper.Map<Publikacija>(publikacija);
        }
    }
}