﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;
using WpfMvvmTemplate.ViewModels.Base;

namespace WpfMvvmTemplate.ViewModels
{
    [MarkupExtensionReturnType(typeof(MainWindowViewModel))]
    public class MainWindowViewModel : ViewModel
    {
        #region Properties
        private string _title = "Title";
        public string Title { get => _title; set => Set(ref _title, value); }

        private string _status = "Status";
        public string Status { get => _status; set => Set(ref _status, value); }
        #endregion

        #region Commands

        #endregion
    }
}
