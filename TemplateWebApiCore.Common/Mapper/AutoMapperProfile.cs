using AutoMapper;
using TemplateWebApiCore.Domain.Business;
using TemplateWebApiCore.Domain.DTO;
using TemplateWebApiCore.DAL.Entity;


namespace TemplateWebApiCore.Common.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDTO, UserModel>();
            CreateMap<UserModel, User>();

            CreateMap<UserInfoDTO, UserInfoModel>().ReverseMap();
        }
    }
}
