using Microsoft.EntityFrameworkCore;

namespace dal
{
   public partial class User
   {
      public int Id { get; set; }
      public string firstName { get; set; }
      public string lastName { get; set; }

      public string username { get; set; }
      public string email { get; set; }
   }
}