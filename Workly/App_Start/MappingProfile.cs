using AutoMapper;
using Workly.Dtos;
using Workly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workly.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Job, JobDTO>();
            Mapper.CreateMap<JobDTO, Job>();
        }
    }
}