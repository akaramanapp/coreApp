using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreApp.Controllers
{
    [Route("api/[controller]")]
    public class PhotoController : Controller
    {
        private PhotoContext _photoContext;
        public PhotoController(PhotoContext context){
           _photoContext = context;
        }
        // GET api/Photo
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> list = new List<User>(){
                new User { UserId=1, UserName="kerim"}
            };
            return list; //_photoContext.Users.ToList();
        }

        // GET api/Photo/5
        [HttpGet("{id}")]
        public Photo Get(int id)
        {
            return _photoContext.Photos.Single(x=> x.PhotoId == id);
        }

        // POST api/Photo
        [HttpPost]
        public void Post([FromBody]Photo photo)
        {
            _photoContext.Photos.Add(photo);
            _photoContext.SaveChanges();
        }

        // PUT api/Photo/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            var photo = Get(id);
            _photoContext.Remove(photo);
            _photoContext.SaveChanges();
        }

        // DELETE api/Photo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
