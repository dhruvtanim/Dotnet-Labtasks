using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Services;
using BLL.DTOs;

namespace APPILAYER.Controllers
{
    public class ProjectController : ApiController
    {
        [HttpGet, Route("api/project")]
        public HttpResponseMessage AllCategories()
        {
            try
            {
                var data = ProjectServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
        [HttpPost, Route("api/project/find/{id}")]
        public HttpResponseMessage FindCategoriess(int id)
        {
            try
            {
                var data = ProjectServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost, Route("api/project/create")]
        public HttpResponseMessage CreateCategory(ProjectDTO category)
        {
            try
            {
                var data = ProjectServices.Create(category);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost, Route("api/project/update")]
        public HttpResponseMessage UpdateCategory(ProjectDTO category)
        {
            try
            {
                var data = ProjectServices.Update(category);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost, Route("api/project/delete/{id}")]
        public HttpResponseMessage DeleteCategory(int id)
        {
            try
            {
                var data = ProjectServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
