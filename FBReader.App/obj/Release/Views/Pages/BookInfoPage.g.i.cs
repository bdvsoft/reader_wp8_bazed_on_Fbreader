﻿#pragma checksum "E:\Dev\Mobile\FBReader\src\FBReader.App\Views\Pages\BookInfoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "96C79542721F6596282B90B477C19595"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace FBReader.App.Views.Pages {
    
    
    public partial class BookInfoPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage BookPage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid BookCoverGrid;
        
        internal Telerik.Windows.Controls.RadListPicker ShareMethodPicker;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Pages/BookInfoPage.xaml", System.UriKind.Relative));
            this.BookPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("BookPage")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.BookCoverGrid = ((System.Windows.Controls.Grid)(this.FindName("BookCoverGrid")));
            this.ShareMethodPicker = ((Telerik.Windows.Controls.RadListPicker)(this.FindName("ShareMethodPicker")));
        }
    }
}

