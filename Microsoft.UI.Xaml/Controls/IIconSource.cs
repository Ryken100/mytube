using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A2 RID: 162
	[ExclusiveTo(typeof(IconSource))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(1848967661U, 56625, 20969, 143, 20, 37, 97, 249, 156, 138, 143)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IIconSource
	{
		// Token: 0x06000211 RID: 529
		IconElement CreateIconElement();

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000212 RID: 530
		// (set) Token: 0x06000213 RID: 531
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		Brush Foreground
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
