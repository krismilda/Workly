using AutoMapper;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Workly.Dtos;
using Workly.Models;

namespace Workly.Controllers.API
{
    public class YourJobsController : ApiController
    {
        private JobSystemContext _context;

        public YourJobsController()
        {
            _context = new JobSystemContext();
        }
        //GET /api/YourJobs
        [System.Web.Http.HttpGet]
        public IEnumerable<JobDTO> GetJobs()
        {
            string id = User.Identity.GetUserId();
            return _context.Jobs.ToList().Select(Mapper.Map<Job, JobDTO>).Where(job=>job.UserId==id);
        }

    }
}