using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;

namespace SelectGradientColors
{
    public class ColorPickerViewModel : NotificationObject
    {
        private BrushTypeOptions brushTypeOptions = BrushTypeOptions.Gradient;
        private ColorSpectrumComponents colorSpectrumComponents = ColorSpectrumComponents.SaturationValue;
        private ColorSpectrumShape colorSpectrumShape = ColorSpectrumShape.Box;
        private AxisInputOption axisInputOption = AxisInputOption.Simple;
        private Brush selectedColor;
        private bool enableAxisInputOption = false;

        public BrushTypeOptions BrushTypeOptions
        {
            get
            {
                return brushTypeOptions;
            }
            set
            {
                if (brushTypeOptions != value)
                {
                    brushTypeOptions = value;
                    this.RaisePropertyChanged(nameof(this.BrushTypeOptions));
                }
            }
        }

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

        public AxisInputOption AxisInputOption
        {
            get
            {
                return axisInputOption;
            }
            set
            {
                if (axisInputOption != value)
                {
                    axisInputOption = value;
                    this.RaisePropertyChanged(nameof(this.AxisInputOption));
                }
            }
        }

        public Brush SelectedColor
        {
            get
            {
                return selectedColor;
            }
            set
            {
                if (selectedColor != value)
                {
                    selectedColor = value;
                    this.RaisePropertyChanged(nameof(this.SelectedColor));
                    this.EnableAxisInputOption = selectedColor is LinearGradientBrush || selectedColor is RadialGradientBrush;
                }
            }
        }        

        public bool EnableAxisInputOption
        {
            get
            {
                return enableAxisInputOption;
            }
            set
            {
                if (enableAxisInputOption != value)
                {
                    enableAxisInputOption = value;
                    this.RaisePropertyChanged(nameof(this.EnableAxisInputOption));
                }
            }
        }
    }
}
