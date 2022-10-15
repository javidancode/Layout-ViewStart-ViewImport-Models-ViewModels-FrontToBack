using Layout_Models.Models;
using Layout_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layout_Models.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //cast elemesen islemir 
            //ViewData["Numbers"] = new int[] {1,2,3,4,5,6,7,8};

            //castsiz isleyir amma baska bir viewda da cagrib istifade oluna bilmir
            //ViewBag.nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //ViewBag.fullName = "Hesenov Eli";

            //TempData["Name"] = "Cavidan";

            //return RedirectToAction(nameof(Detail));

            List<Book> books = new List<Book>();

            Car car = new Car
            {
                Id = 1,
                Name = "BMW",
                Color = "Pink"

            };

            Book book1 = new Book
            {
                Id = 1,
                Name = "1Yeddi Gozel",
                AuthorName = "1Nizami",
                PublishDate = new DateTime(2000,5,1)

            };


            Book book2 = new Book
            {
                Id = 2,
                Name = "2Yeddi Gozel",
                AuthorName = "2Nizami",
                PublishDate = new DateTime(2000, 5, 1)

            };


            Book book3 = new Book
            {
                Id = 3,
                Name = "3Yeddi Gozel",
                AuthorName = "3Nizami",
                PublishDate = new DateTime(2000, 5, 1)

            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            HomeVM model = new HomeVM
            {
                Books = books,
                Car = car
            };




            return View(model);


            
        }

        //public IActionResult Detail()
        //{
        //    //ViewBag.fullName = "Qedirli Cavidan";
        //    return View();
        //}
    }
}
