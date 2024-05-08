using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using TwiceBackend.Entity;
using TwiceBackend.DTO;

namespace TwiceBackend.Utilities
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      #region Group
        CreateMap<Group, GroupDTO>().ReverseMap();
        CreateMap<GroupRequestDTO, GroupDTO>().ReverseMap();
      #endregion Group
    }
  }
}
