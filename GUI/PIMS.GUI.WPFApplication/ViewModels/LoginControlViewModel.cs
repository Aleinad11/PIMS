using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PIMS.GUI.WPFApplication.ViewModels
{
    public class LoginControlViewModel : BindableBase
    {
        private string _loginId = null;
        public string LoginId
        {
            get { return _loginId; }
            set { SetProperty(ref _loginId, value);  }
        }

        public LoginControlViewModel()
        {

        }
    }
}
