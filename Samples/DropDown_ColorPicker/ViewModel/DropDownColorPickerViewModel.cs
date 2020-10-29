using Microsoft.UI;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropDown_ColorPicker
{
    class DropDownColorPickerViewModel : NotificationObject
    {
        private Brush selectedBrush = new SolidColorBrush(Colors.Red);
        private FlyoutPlacementMode flyoutPlacementMode = FlyoutPlacementMode.BottomEdgeAlignedRight;
        private DropDownMode dropDownMode = DropDownMode.Split;

        public Brush SelectedBrush
        {
            get
            {
                return selectedBrush;
            }
            set
            {
                if (this.selectedBrush != value)
                {
                    this.selectedBrush = value;
                    this.RaisePropertyChanged(nameof(this.SelectedBrush));
                }
            }
        }

        public DropDownMode DropDownMode
        {
            get
            {
                return dropDownMode;
            }
            set
            {
                if (this.dropDownMode != value)
                {
                    this.dropDownMode = value;
                    this.RaisePropertyChanged(nameof(this.DropDownMode));
                }
            }
        }

        public FlyoutPlacementMode FlyoutPlacementMode
        {
            get
            {
                return flyoutPlacementMode;
            }
            set
            {
                if (this.flyoutPlacementMode != value)
                {
                    this.flyoutPlacementMode = value;
                    this.RaisePropertyChanged(nameof(this.FlyoutPlacementMode));
                }
            }
        }
    }
}
