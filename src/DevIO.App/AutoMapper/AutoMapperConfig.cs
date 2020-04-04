using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Bussines.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Siati, SiatiViewModel>().ReverseMap();
        }
    }
}
