using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestMvcApp.Models;

namespace TestMvcApp.Controllers
{
    public class StudentController : ApiController
    {
        public List<StudentModel> Get()
        {
            var list =  new List<StudentModel>();
            list.Add(new StudentModel
            {
                RollNumber="BSEF14M041",
                StudentName="Muzna Aleem"
            });
            list.Add(new StudentModel
            {
                RollNumber = "BSEF09M008",
                StudentName = "Faisal Ghaffar"
            });

            return list;
        }
    }
}
