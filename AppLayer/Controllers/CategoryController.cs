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
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("api/allcategory")]
        public HttpResponseMessage GetAllCategory()
        {
            try
            {
                var data = CategoryService.GetAll();
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
        [Route("api/addCategory")]
        public HttpResponseMessage CreateCategory(CategoryDTO category)
        {
            try
            {
                var res = CategoryService.Add(category);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "New category created");
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
        [HttpPost]
        [Route("api/updateCategory")]
        public HttpResponseMessage UpdateCategory(CategoryDTO category)
        {
            try
            {
                var res = CategoryService.Update(category);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "failed to update");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        } 
        [HttpGet]
        [Route("api/deleteCategory")]
        public HttpResponseMessage DeleteCategory(int? id)
        {
            if (!id.HasValue)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id is required");
            }

            try
            {
                var res = CategoryService.Delete(id.Value);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "failed to delete");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }
    }
}
