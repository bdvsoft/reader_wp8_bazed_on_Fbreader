﻿#pragma checksum "C:\Users\Дмитрий\Desktop\Читай 2\FBReader.App\Views\Pages\Settings\MarginsSettingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B577E74F4FDCF5A97519B9D26326983"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FBReader.App.Views.Controls;
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


namespace FBReader.App.Views.Pages.Settings {
    
    
    public partial class MarginsSettingPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid Display;
        
        internal System.Windows.Controls.TextBlock DummyText;
        
        internal FBReader.App.Views.Controls.MarginGridControl LineGrid;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Views/Pages/Settings/MarginsSettingPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Display = ((System.Windows.Controls.Grid)(this.FindName("Display")));
            this.DummyText = ((System.Windows.Controls.TextBlock)(this.FindName("DummyText")));
            this.LineGrid = ((FBReader.App.Views.Controls.MarginGridControl)(this.FindName("LineGrid")));
        }
    }
}

