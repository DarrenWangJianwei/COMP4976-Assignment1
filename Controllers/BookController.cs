using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Books.Models;
using Newtonsoft.Json;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace Books.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var url = "https://www.googleapis.com/books/v1/volumes?q=harry+potter";
            var WebClient = new WebClient();
            var json = WebClient.DownloadString(url);
            var book = JsonConvert.DeserializeObject<jsonToObj>(json);
            return View(book);
        }

        public IActionResult Detail(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var url = "https://www.googleapis.com/books/v1/volumes?q=harry+potter";
            var WebClient = new WebClient();
            var json = WebClient.DownloadString(url);
            var book = JsonConvert.DeserializeObject<jsonToObj>(json);
            var findTheObject = new EachItem();
            for(var i=0;i<book.items.Length;i++){
                if(book.items[i].id == id){
                    findTheObject = book.items[i].volumeInfo;
                }
            }
            return View(findTheObject);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
