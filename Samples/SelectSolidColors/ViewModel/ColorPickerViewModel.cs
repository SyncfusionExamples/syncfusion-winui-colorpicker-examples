using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;

namespace SelectSolidColors
{
    public class ColorPickerViewModel : NotificationObject
    {
        private ColorInputOptions alphaInputOptions = ColorInputOptions.All;
        private ColorInputOptions colorChannelInputOptions = ColorInputOptions.All;
        private ColorEditorsVisibilityMode colorEditorsVisibilityMode = ColorEditorsVisibilityMode.Inline;
        private ColorSpectrumComponents colorSpectrumComponents = ColorSpectrumComponents.HueSaturation;
        private ColorSpectrumShape colorSpectrumShape = ColorSpectrumShape.Box;
        private Brush selectedBrush;
        private string colorChannelOptions =  "All";
        private bool isHexInputVisible = true;

        public ColorSpectrumComponents ColorSpectrumComponents
        {
            get
            {
                return colorSpectrumComponents;
            }
            set
            {
                if (colorSpectrumComponents != value)
                {
                    colorSpectrumComponents = value;
                    this.RaisePropertyChanged(nameof(this.ColorSpectrumComponents));
                }
            }
        }

        public ColorSpectrumShape ColorSpectrumShape
        {
            get
            {
                return colorSpectrumShape;
            }
            set
            {
                if (colorSpectrumShape != value)
                {
                    colorSpectrumShape = value;
                    this.RaisePropertyChanged(nameof(this.ColorSpectrumShape));
                }
            }
        }
        public bool IsHexInputVisible
        {
            get
            {
                return isHexInputVisible;
            }
            set
            {
                if (isHexInputVisible != value)
                {
                    isHexInputVisible = value;
                    this.RaisePropertyChanged(nameof(this.IsHexInputVisible));
                }
            }
        }
        
        public ColorInputOptions AlphaInputOptions
        {
            get
            {
                return alphaInputOptions;
            }
            set
            {
                if (alphaInputOptions != value)
                {
                    alphaInputOptions = value;
                    this.RaisePropertyChanged(nameof(this.AlphaInputOptions));
                }
            }
        }

        public ColorInputOptions ColorChannelInputOptions
        {
            get
            {
                return colorChannelInputOptions;
            }
            set
            {
                if (colorChannelInputOptions != value)
                {
                    colorChannelInputOptions = value;
                    this.RaisePropertyChanged(nameof(this.ColorChannelInputOptions));
                }
            }
        }

        public ColorEditorsVisibilityMode ColorEditorsVisibilityMode
        {
            get
            {
                return colorEditorsVisibilityMode;
            }
            set
            {
                if (colorEditorsVisibilityMode != value)
                {
                    colorEditorsVisibilityMode = value;
                    this.RaisePropertyChanged(nameof(this.ColorEditorsVisibilityMode));
                }
            }
        }

        public Brush SelectedBrush
        {
            get
            {
                return selectedBrush;
            }
            set
            {
                if (selectedBrush != value)
                {
                    selectedBrush = value;
                    this.RaisePropertyChanged(nameof(this.SelectedBrush));
                }
            }
        }

        public string ColorChannelOptions
        {
            get
            {
                return colorChannelOptions;
            }
            set
            {
                if (colorChannelOptions != value)
                {
                    colorChannelOptions = value;
                    this.RaisePropertyChanged(nameof(this.ColorChannelOptions));
                }
            }
        }
    }
}
