using System;
using System.Collections.Generic;
using System.Text;

namespace Qorder.ViewModels
{
    // ViewModel For login View
   public  class LoginViewModel
    {
        // Properties for login  View

        public string UserName { get; set; }
        public string  Password { get; set; }
        public bool Rememberme { get; set; }
    }
}
