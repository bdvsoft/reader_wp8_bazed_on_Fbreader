﻿#pragma checksum "E:\Dev\Mobile\FBReader\src\FBReader.App\Views\Pages\UserLibraryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "154C3E47BA891778F22D9D6F0781C107"
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
    
    
    public partial class UserLibraryPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadContextMenuItem PinMenuItem;
        
        internal Telerik.Windows.Controls.RadContextMenuItem DeleteMenuItem;
        
        internal Telerik.Windows.Controls.RadContextMenuItem RemoveFromFavouritesMenuItem;
        
        internal System.Windows.Controls.Canvas BlockCanvas;
        
        internal System.Windows.Controls.Primitives.Popup SortModePopup;
        
        internal System.Windows.Controls.StackPanel OrderStackPanel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Pages/UserLibraryPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PinMenuItem = ((Telerik.Windows.Controls.RadContextMenuItem)(this.FindName("PinMenuItem")));
            this.DeleteMenuItem = ((Telerik.Windows.Controls.RadContextMenuItem)(this.FindName("DeleteMenuItem")));
            this.RemoveFromFavouritesMenuItem = ((Telerik.Windows.Controls.RadContextMenuItem)(this.FindName("RemoveFromFavouritesMenuItem")));
            this.BlockCanvas = ((System.Windows.Controls.Canvas)(this.FindName("BlockCanvas")));
            this.SortModePopup = ((System.Windows.Controls.Primitives.Popup)(this.FindName("SortModePopup")));
            this.OrderStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("OrderStackPanel")));
        }
    }
}

