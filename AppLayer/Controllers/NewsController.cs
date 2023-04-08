using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppLayer.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/allnews")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = NewsService.GetAll();
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "No data found");
                }
                
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }


        [HttpPost]
        [Route("api/addNews")]
        public HttpResponseMessage CreateNews(NewsDTO news)
        {
            try
            {
                var res = NewsService.Add(news);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "News created");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "failed to create");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }

    }
}
