using System;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000177 RID: 375
	[WebHostHidden]
	[ExclusiveTo(typeof(UniformGridLayout))]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(3775241166U, 23001, 21193, 140, 13, 197, 251, 134, 232, 51, 161)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IUniformGridLayoutStatics
	{
		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600067E RID: 1662
		DependencyProperty OrientationProperty { get; }

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600067F RID: 1663
		DependencyProperty MinItemWidthProperty { get; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000680 RID: 1664
		DependencyProperty MinItemHeightProperty { get; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000681 RID: 1665
		DependencyProperty MinRowSpacingProperty { get; }

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000682 RID: 1666
		DependencyProperty MinColumnSpacingProperty { get; }

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000683 RID: 1667
		DependencyProperty ItemsJustificationProperty { get; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000684 RID: 1668
		DependencyProperty ItemsStretchProperty { get; }

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000685 RID: 1669
		DependencyProperty MaximumRowsOrColumnsProperty { get; }
	}
}
