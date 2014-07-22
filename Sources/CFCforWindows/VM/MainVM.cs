using CFCforWindowsPhone.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFCforWindows.VM
{
    public class MainVM : BaseVM
    {
        private LoginVM _loginVM;
        
        public LoginVM LoginVM
        {
            get { return _loginVM; }
        }

        public MainVM()
        {
            _loginVM = new LoginVM();
        }
    }
}