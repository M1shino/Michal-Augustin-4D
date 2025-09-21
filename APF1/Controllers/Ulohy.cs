using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APF1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APF1.Controllers
{
    public class Ulohy : Controller
    {
        public IActionResult uloha1()
        {
            return View();
        }
        public IActionResult uloha2()
        {
            return View();
        }
        public IActionResult uloha3()
        {
            return View();
        }
        public IActionResult uloha4()
        {
            var userList = new List<UserInfo>()
            {
                new UserInfo {
                Name = "John Doe 1",
                Email= "johno@ggamil.com",
                Password= "password123",
                Phone= "123-456-7890"
                },
                new UserInfo {
                Name = "John Doe 2",
                Email= "johno@ggamil.com",
                Password= "password123",
                Phone= "123-456-7890"
                },
                new UserInfo {
                Name = "John Doe 3",
                Email= "johno@ggamil.com",
                Password= "password123",
                Phone= "123-456-7890"
                },


              };

            return View(userList);
        }
        public IActionResult uloha5()
        {
            var userList = new List<UserInfo>()
            {
                new UserInfo {
                Name = "John Doe 1",
                Email= "johno@ggamil.com",
                Password= "password123",
                Phone= "123-456-7890"
                },
                new UserInfo {
                Name = "John Doe 2",
                Email= "johno@ggamil.com",
                Password= "password123",
                Phone= "123-456-7890"
                },
                new UserInfo {
                Name = "John Doe 3",
                Email= "johno@ggamil.com",
                Password= "password123",
                Phone= "123-456-7890"
                },


              };

            return View(userList);
        }
        public IActionResult Uloha6()
        {
            return View();
        }

        public IActionResult Uloha7()
        {
            return View();
        }

        public IActionResult Uloha8()
        {
            return View();
        }
    }
}

