using System.Diagnostics;

namespace AgendaMongoDB.Models
{
  [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
  public class User
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Contact> Contacts { get; set; }

    private string GetDebuggerDisplay()
    {
      return ToString();
    }
  }
}
