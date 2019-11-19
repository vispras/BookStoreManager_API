
using GetNewBookList_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace API_GetBookList.Controllers
{
    public class GetBookListController : ApiController
    {
        // GET: api/GetBookList
        private GetBookList[] GetBookLists = new GetBookList[]
    {
        new GetBookList { ID = 7, Title = "Harry Potter: The Illustrated Collection",Author = "J.K. Rowling", Price = 65, Quantity = 14},
         new GetBookList { ID = 8, Title = "IT'S ALL IN YOUR HEAD",Author = "Russ", Price = 11, Quantity = 16}
    };
        // GET: api/GetBookLists
        [ResponseType(typeof(IEnumerable<GetBookList>))]
        public IEnumerable<GetBookList> Get()
        {
            return GetBookLists;
        }
        // GET: api/GetBookLists/5
        public IHttpActionResult Get(int ID)
        {
            var product = GetBookLists.FirstOrDefault((p) => p.ID == ID);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/GetBookList
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetBookList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GetBookList/5
        public void Delete(int id)
        {
        }
    }
}
