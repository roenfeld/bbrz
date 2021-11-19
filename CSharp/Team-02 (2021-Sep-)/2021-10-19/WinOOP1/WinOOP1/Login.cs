using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP1
{
  class Login
  {
    public static int MinPwdLen = 8;

    public const int MaxPwdLen = 24;

    public string UserName { get; set; }
    public string Password { get; set; }

    public void ChangePassword(string newPassword)
    {
      if ( newPassword.Length < Login.MinPwdLen)
      {
        throw new Exception("...");
      }

      if (newPassword.Length > Login.MaxPwdLen)
      {
        throw new Exception("...");
      }
    }


  }


}
