using Microsoft.AspNetCore.Mvc;
using MyFirstProj_TreeView.DataContext;
using MyFirstProj_TreeView.Models;
using MyFirstProj_TreeView.Repositories;
using MyFirstProj_TreeView.Services;
using System;
using System.Linq;
using System.Net;



namespace MyFirstProj_TreeView.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private UserMapper _mapper;
        private UserRepository _repository;

        public UserController(UserMapper mapper,UserRepository repository)
        {
            _mapper = mapper;
            _repository = repository;

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok( _repository.GetAll().Select(x=> _mapper.MapToEntity(x)));
            }
            catch(Exception exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

        }

        [HttpGet("{id:int}" , Name ="GetSingle")]
        public IActionResult Get(int id)
        {
            try
            {
                User user = _repository.GetSingle(id);

                if(user == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.MapToEntity(user));

            }
            catch (Exception exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }

            }catch(Exception ex)
            {

            }

            _repository.Create(user);
            return Ok(_mapper.MapToEntity(user));

        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id,[FromBody] User user)
        {
            try
            {
                if(user == null)
                {
                    return BadRequest();
                }

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                User updateuser = _repository.GetSingle(id);

                updateuser.UserName = user.UserName;
                updateuser.UserId = user.UserId;
                updateuser.UserPassword = user.UserPassword;

                _repository.Update(updateuser);

                return Ok(_mapper.MapToEntity(updateuser));
                
            }
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }


    }
}
