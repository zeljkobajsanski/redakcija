using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ninject;
using Redakcija.Web.Models;
using Redakcija.Web.Services;

namespace Redakcija.Web.Controllers
{
    public class PublikacijeController : ApiController
    {
        private readonly TestService m_TestService;

        public PublikacijeController()
        {
        }

        [Inject]
        public PublikacijeController(TestService testService)
        {
            m_TestService = testService;
        }

        // GET api/publikacije
        public IEnumerable<Publikacija> Get()
        {
            return m_TestService.VratiPublikacije();
        }

        // GET api/publikacije/5
        public Publikacija Get(int id)
        {
            return null;
        }

        // POST api/publikacije
        public void Post([FromBody]string value)
        {
        }

        // PUT api/publikacije/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/publikacije/5
        public void Delete(int id)
        {
        }
    }
}
