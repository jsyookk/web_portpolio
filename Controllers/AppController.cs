using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstProj_TreeView.Services;
using MyFirstProj_TreeView.Repositories;
using MyFirstProj_TreeView.Models;
using System.Net;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstProj_TreeView.Controllers
{
    public class AppController : Controller
    {
        private CategoryRepository _repository;
        private CategoryMapper _mapper;

        public AppController(CategoryMapper mapper,CategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
                

        }
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            try
            {
                List<Category> categorys = _repository.GetAll();

                foreach (Category cat in categorys)
                {
                    Console.WriteLine(cat);

                }

               // ViewBag.data = categorys;

                return View(categorys);


                //return Ok(_mapper.MapToEntity(user));

            }
            catch (Exception exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

            return View();
     
        }

        [HttpGet("{id:int}")]
        public IActionResult Index(int id)
        {
            try
            {
                List<Category> categorys = _repository.GetUserCategory(id);

                foreach(Category cat in categorys)
                {
                    Console.WriteLine(cat);

                }

                //ViewBag.data = categorys;

                return View(categorys);

                //return Ok(_mapper.MapToEntity(user));

            }
            catch (Exception exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

           
        }


    }
}
