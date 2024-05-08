using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwiceBackend.DTO
{
  public class GroupRequestDTO
  {
    public string GroupName { get; set; } = null!;

    public string? GroupKoreanName { get; set; }

    public string? GroupJapaneseName { get; set; }

    public string? GroupChineseName { get; set; }

    public string? GroupDescription { get; set; }

    public string? GroupOrigin { get; set; }
  }
}
