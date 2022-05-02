﻿using MathCore.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookinist.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        #region Title : TYPE - DESCRIPTION

        /// <summary>Заголовок</summary>
        private string _Title = "Главное окно программы";

        /// <summary>Заголовок </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion
    }
}
