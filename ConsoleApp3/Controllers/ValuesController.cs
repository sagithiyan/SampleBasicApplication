using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp3.Controllers
{

    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("get-all")]
        [Route("api/get-all")]
        [Route("getall")]
        public string GetAll()
        {

            return "Hello from get All";
        }


        [Route("get-auth")]
        public string GetAllAuthors()
        {

            return "Hello from get all authors";

        }

        [Route("books/{id}")]
        public string GetById(int id)
        {

            return "Hello" + id;

        }

        [Route("books/{id}/author/{authorid}")]
        public string GetByAuthorId(int id, int authorid)
        {

            return "Hello Author " + id + " " + authorid;

        }

        [Route("search")]
        public string SearchBooks(int id, int authorid,string name,int rating,int price)
        {

            return "Hello Search";

        }


    }
}
