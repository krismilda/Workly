using AutoMapper;
using Workly.Dtos;
using Workly.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Workly.Controllers.API
{
    public class JobsController : ApiController
    {
        private JobSystemContext _context;

        public JobsController()
        {
            _context = new JobSystemContext();
        }
        //GET /api/jobs
        [HttpGet]
        public IEnumerable<JobDTO> GetJobs()
        {
            return _context.Jobs.ToList().Select(Mapper.Map<Job, JobDTO>);
        }

        //GET /api/jobs/id
        [HttpGet]
        public JobDTO getJob(int id)
        {
            Job job = _context.Jobs.SingleOrDefault(j => j.Id == id);

            if (job == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Job, JobDTO>(job);
        }

        //POST api/jobs
        [HttpPost]
        public IHttpActionResult createJob(JobDTO jobDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Job job = Mapper.Map<JobDTO, Job>(jobDto);
            _context.Jobs.Add(job);
            _context.SaveChanges();

            jobDto.Id = job.Id;
            return Created(new Uri(Request.RequestUri + "/" + job.Id), jobDto);
        }

        //PUT api/jobs/1
        [HttpPut]
        public void UpdateJob(int id, JobDTO jobDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            Job jobInDB = _context.Jobs.SingleOrDefault(j => j.Id == id);

            if (jobInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(jobDto, jobInDB);
            _context.SaveChanges();
        }

        //DELETE api/jobs/id
        [HttpDelete]
        public void DeleteJob(int id, Job job)
        {
            Job jobInDB = _context.Jobs.SingleOrDefault(j => j.Id == id);

            if (jobInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Jobs.Remove(jobInDB);
            _context.SaveChanges();

        }
    }
}
