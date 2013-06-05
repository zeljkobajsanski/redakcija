using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using Redakcija.Model.Interfaces;
using Redakcija.Web.Models;

namespace Redakcija.Web.Services
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TestService
    {
        private readonly IPublikacijeRepository m_PublikacijeRepository;

        public TestService()
        {
        }

        public TestService(IPublikacijeRepository publikacijeRepository)
        {
            m_PublikacijeRepository = publikacijeRepository;
        }

        [OperationContract]
        public void PosaljiClanak(Clanak clanak)
        {
            var rootDir = HttpContext.Current.Server.MapPath("~/App_Data/DMS/");
            using (var s = File.Create(rootDir + Guid.NewGuid().ToString("N") + ".rtf"))
            {
                s.Write(clanak.Raw, 0, clanak.Raw.Length);
            }
        }

        [OperationContract]
        public IEnumerable<Publikacija> VratiPublikacije()
        {
            var publikacije = m_PublikacijeRepository.VratiPublikacijeSaRubrikama().ToArray();
            return publikacije.Select(ObjectMapper.Map);
        }
    }
}
