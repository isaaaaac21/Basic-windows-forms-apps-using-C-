using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactBusinessLayer; 
namespace ContactForm
{
      public class LoginPannel
    {
        static public bool isVisible = false; 
        static public bool CheckLoginInfo(TextBox tbUsrName, TextBox tbPassword)
        {
           return clsUsers.UserExists(tbUsrName.Text, tbPassword.Text); 
        }

        static public void ShowPassword(ref TextBox tbPassword)
        {
            if (isVisible)
            {
                tbPassword.PasswordChar = '*';
                isVisible = false; 
            }
            else
            {
                tbPassword.PasswordChar = '\0';
                isVisible = true; 
            }
        }

        

    }
}
