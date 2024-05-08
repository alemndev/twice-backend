using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TwiceBackend.Utilities;
using TwiceBackend.BLL.Services.Contract;
using TwiceBackend.Entity;
using AutoMapper;
using TwiceBackend.DTO;

namespace TwiceBackend.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GroupController : ControllerBase
  {
    private readonly IGroupService _groupService;
    private readonly IMapper _mapper;

    public GroupController(IGroupService groupService, IMapper mapper)
    {
      _groupService = groupService;
      _mapper = mapper;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult> Group()
    {
      GenericResponse<GroupDTO> rsp = new();

      try
      {
        var Group = await _groupService.GetGroup(1);

        if (Group == null)
        {
          rsp.OK = false;
          rsp.Msg = "group not found";

          return BadRequest(rsp);
        }

        rsp.OK = true;
        rsp.Value = Group;

        return Ok(rsp);
      }
      catch (Exception ex)
      {
        rsp.OK = false;
        rsp.Msg = ex.Message;

        return BadRequest(rsp);
      }
    }

    [HttpGet]
    [Route("groups")]
    public async Task<ActionResult> Groups()
    {
      GenericResponse<List<GroupDTO>> rsp = new();

      try
      {
        var ListGroups = await _groupService.GetGroups();

        if (ListGroups.Count() == 0)
        {
          rsp.OK = false;
          rsp.Msg = "without groups";

          return BadRequest(rsp);
        }

        rsp.OK = true;
        rsp.Value = ListGroups;

        return Ok(rsp);
      }
      catch (Exception ex)
      {
        rsp.OK = false;
        rsp.Msg = ex.Message;

        return BadRequest(rsp);
      }
    }

    [HttpPost]
    [Route("create")]
    public async Task<ActionResult> Group([FromBody] GroupRequestDTO model)
    {
      GenericResponse<GroupDTO> rsp = new();

      try
      {
        var Group = await _groupService.CreateGroup(_mapper.Map<GroupDTO>(model));

        if (Group == null)
        {
          rsp.OK = false;
          rsp.Msg = "group not found";

          return BadRequest(rsp);
        }

        rsp.OK = true;
        rsp.Value = Group;

        return Ok(rsp);
      }
      catch (Exception ex)
      {
        rsp.OK = false;
        rsp.Msg = ex.Message;

        return BadRequest(rsp);
      }
    }
  }
}
