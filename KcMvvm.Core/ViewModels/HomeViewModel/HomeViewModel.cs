using System;
using Cirrious.MvvmCross.ViewModels;
using KcMvvm.Core.Commands;

namespace KcMvvm.Core.ViewModels.HomeViewModel
{
    public class HomeViewModel : KcViewModel
    {
        public HomeViewModel()
        {
            
        }

        #region Properties

        public string Title
        {
            get
            {
                return "Home Screen";
            }
        }

        #endregion

        #region Commands

        #endregion
        
        #region Events

        #endregion

    }
}