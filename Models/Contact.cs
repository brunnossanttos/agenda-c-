using System.Diagnostics;

namespace AgendaMongoDB.Models
{
  [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
  public class Contact
  {
    public string Name { get; set; }

    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    private string GetDebuggerDisplay()
    {
      return ToString();
    }
  }
}


