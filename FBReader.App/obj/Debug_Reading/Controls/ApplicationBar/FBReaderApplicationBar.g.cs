﻿#pragma checksum "C:\Users\Дмитрий\Desktop\Читай 2\FBReader.App\Controls\ApplicationBar\FBReaderApplicationBar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2EE56F7FC97FA310CC82BCE44921E258"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FBReader.App.Controls.ApplicationBar;
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


namespace FBReader.App.Controls.ApplicationBar {
    
    
    public partial class FBReaderApplicationBar : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl AppBar;
        
        internal System.Windows.Controls.Border RootBorder;
        
        internal FBReader.App.Controls.ApplicationBar.FBSlider Slider;
        
        internal System.Windows.Controls.Grid IconButtonsGrid;
        
        internal System.Windows.Controls.ItemsControl IconButtonsPanel;
        
        internal System.Windows.Controls.StackPanel PageSelectionButtonsPanel;
        
        internal System.Windows.Controls.ScrollViewer MenuScroll;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/FBReader.App;component/Controls/ApplicationBar/FBReaderApplicationBar.xaml", System.UriKind.Relative));
            this.AppBar = ((System.Windows.Controls.UserControl)(this.FindName("AppBar")));
            this.RootBorder = ((System.Windows.Controls.Border)(this.FindName("RootBorder")));
            this.Slider = ((FBReader.App.Controls.ApplicationBar.FBSlider)(this.FindName("Slider")));
            this.IconButtonsGrid = ((System.Windows.Controls.Grid)(this.FindName("IconButtonsGrid")));
            this.IconButtonsPanel = ((System.Windows.Controls.ItemsControl)(this.FindName("IconButtonsPanel")));
            this.PageSelectionButtonsPanel = ((System.Windows.Controls.StackPanel)(this.FindName("PageSelectionButtonsPanel")));
            this.MenuScroll = ((System.Windows.Controls.ScrollViewer)(this.FindName("MenuScroll")));
        }
    }
}

