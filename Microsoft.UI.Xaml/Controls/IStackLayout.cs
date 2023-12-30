using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200012D RID: 301
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Guid(1811412507U, 3311, 23954, 168, 40, 147, 239, 189, 109, 244, 193)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(StackLayout))]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IStackLayout
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060004D8 RID: 1240
		// (set) Token: 0x060004D9 RID: 1241
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
		Orientation Orientation
		{
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::Orientation::Vertical")]
			[param: In]
			set;
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060004DA RID: 1242
		// (set) Token: 0x060004DB RID: 1243
		[MUXPropertyDefaultValue(value = "0.0")]
		[MUXPropertyDefaultValue(value = "0.0")]
		double Spacing
		{
			[MUXPropertyDefaultValue(value = "0.0")]
			get;
			[MUXPropertyDefaultValue(value = "0.0")]
			[param: In]
			set;
		}
	}
}
