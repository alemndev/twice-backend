using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TwiceBackend.BLL.Services.Contract;
using TwiceBackend.DAL.Repositories;
using TwiceBackend.DAL.Repositories.Contract;
using TwiceBackend.DTO;
using TwiceBackend.Entity;
using TwiceBackend.Utilities;

namespace TwiceBackend.BLL.Services
{
  public class GroupService : IGroupService
  {
    private readonly IGenericRepository<Group> _groupRepository;
    private readonly IMapper _mapper;

    public GroupService(IGenericRepository<Group> groupRepository, IMapper mapper)
    {
      _groupRepository = groupRepository;
      _mapper = mapper;
    }
    public async Task<GroupDTO> GetGroup(int id)
    {
      try
      {
        int TwiceDefaultGroup = 1;
        var FindGroup = await _groupRepository.Get(g => g.GroupId == TwiceDefaultGroup);

        return _mapper.Map<GroupDTO>(FindGroup);
      }
      catch (Exception)
      {

        throw;
      }
    }

    public async Task<List<GroupDTO>> GetGroups()
    {
      try
      {
        var queryGroup = await _groupRepository.Query();
        var listGroups = queryGroup.ToList();

        return _mapper.Map<List<GroupDTO>>(listGroups);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public async Task<GroupDTO> CreateGroup(GroupDTO model)
    {
      try
      {
        var FindCreatedGroup = await _groupRepository.Query(g => g.GroupName == model.GroupName);
        
        if (FindCreatedGroup != null)
        {
          throw new TaskCanceledException("group exist");
        }

        var Group = await _groupRepository.Create(_mapper.Map<Group>(model));
      
        if (Group.GroupId == 0)
        {
          throw new TaskCanceledException("failed to create group");
        }

        return _mapper.Map<GroupDTO>(Group);
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
