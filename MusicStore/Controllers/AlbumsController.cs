using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            // Create a mock list of type Album
            var albums = new List<Album>();

            for(int i = 1; i <= 10; i++)
            {
                albums.Add(new Album { Title = "Album " + i.ToString() });
            }
            // ViewBag.albums = albums.OrderBy(a => a.Title);
            
            return View(albums);
        }
    }
}