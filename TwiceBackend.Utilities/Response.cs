using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwiceBackend.Utilities
{
  public class GenericResponse<T>
  {
    public bool OK { get; set; }
    public T? Value { get; set; }
    public string? Msg { get; set; }
  }
}
