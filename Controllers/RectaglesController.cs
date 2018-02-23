using System;
using Microsoft.AspNetCore.Mvc;
using RectangleChecker.Models;

namespace RectanglesChecker.Controllers
 {
   public class RectanglesController : Controller
   {
     [HttpGet("/rectangles")]
     public ActionResult Index()
     {
       return View("CreateForm");
     }

     [HttpGet("/rectangle/result")]
     public ActionResult Result()
     {
       Rectangle myRectangle = new Rectangle(Int32.Parse(Request.Query["side-length"]), Int32.Parse(Request.Query["side-width"]));
       return View("RectangleResult", myRectangle);
     }
   }
 }
