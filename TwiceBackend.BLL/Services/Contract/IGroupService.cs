using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TwiceBackend.DTO;
using TwiceBackend.Entity;

namespace TwiceBackend.BLL.Services.Contract
{
  public interface IGroupService
  {
    Task<GroupDTO> GetGroup(int id);
    Task<List<GroupDTO>> GetGroups();
    Task<GroupDTO> CreateGroup(GroupDTO model);
  }
}
