using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesMVC.Controllers
{
        public class HelloWorldController : Controller
        {
        // 
        // GET: /HelloWorld/ 
        // This is the HelloWorld action method...
        public string Index()
            {
                return "This is my <b>default</b> action...";
            }

        // 
        // GET: /HelloWorld/Welcome/ 
        // This is the Welcome action method...
        public string Welcome()
            {
                return "This is the Welcome action method...";
            }
        }
    }