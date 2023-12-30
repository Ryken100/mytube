using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000175 RID: 373
	[Guid(2259960317U, 13806, 20836, 158, 199, 185, 37, 66, 100, 139, 75)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(UniformGridLayout))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IUniformGridLayout
	{
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600066D RID: 1645
		// (set) Token: 0x0600066E RID: 1646
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
		Orientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Horizontal")]
			[param: In]
			set;
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600066F RID: 1647
		// (set) Token: 0x06000670 RID: 1648
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		double MinItemWidth
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000671 RID: 1649
		// (set) Token: 0x06000672 RID: 1650
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		double MinItemHeight
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000673 RID: 1651
		// (set) Token: 0x06000674 RID: 1652
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		double MinRowSpacing
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000675 RID: 1653
		// (set) Token: 0x06000676 RID: 1654
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		double MinColumnSpacing
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000677 RID: 1655
		// (set) Token: 0x06000678 RID: 1656
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
		UniformGridLayoutItemsJustification ItemsJustification
		{
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsJustification::Start")]
			[param: In]
			set;
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000679 RID: 1657
		// (set) Token: 0x0600067A RID: 1658
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
		UniformGridLayoutItemsStretch ItemsStretch
		{
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::UniformGridLayoutItemsStretch::None")]
			[param: In]
			set;
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x0600067B RID: 1659
		// (set) Token: 0x0600067C RID: 1660
		[MUXPropertyDefaultValue(value = "-1")]
		[MUXPropertyDefaultValue(value = "-1")]
		int MaximumRowsOrColumns
		{
			[MUXPropertyDefaultValue(value = "-1")]
			get;
			[MUXPropertyDefaultValue(value = "-1")]
			[param: In]
			set;
		}
	}
}
