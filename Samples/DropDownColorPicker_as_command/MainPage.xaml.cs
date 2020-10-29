using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Core;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DropDownColorPicker_as_command
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ICommand selectionChangedCommand;
        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
        }
        public void SelectionChangedMethod(object param)
        {
            richTextBox.Document.Selection.CharacterFormat.BackgroundColor
                = (sfDropDownColorPicker.SelectedBrush as SolidColorBrush).Color;

        }
        public MainPage()
        {
            this.InitializeComponent();
            selectionChangedCommand = new DelegateCommand<object>(SelectionChangedMethod);
            richTextBox.Document.SetText(Microsoft.UI.Text.TextSetOptions.None,
                "The Dropdown Color Picker allows users to edit a solid and gradient brush " +
                "through a drop-down menu, and provides RGB, HSV, HSL, CMYK, and " +
                "hex color modes for color selection.");
            richTextBox.Document.Selection.StartPosition = 0;
            richTextBox.Document.Selection.EndPosition = 18;
        }
    }
}
