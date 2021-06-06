using AttachmentsService.Data;
using AttachmentsService.Data.Dto;
using AttachmentsService.Data.ViewModel.Input;
using AttachmentsService.Data.Entity;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using System;
using System.Linq;

namespace AttachmentsService.API.Configurations.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Attachment, AttachmentDto>();

            CreateMap<AttachmentDto, Attachment>();
        }
    }
}
