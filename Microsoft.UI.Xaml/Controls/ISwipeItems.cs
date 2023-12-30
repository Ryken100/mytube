using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000137 RID: 311
	[ExclusiveTo(typeof(SwipeItems))]
	[Guid(1087570475U, 51243, 21861, 164, 228, 173, 157, 122, 102, 177, 169)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface ISwipeItems
	{
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000506 RID: 1286
		// (set) Token: 0x06000507 RID: 1287
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
		[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
		[MUXPropertyChangedCallback(enable = true)]
		SwipeMode Mode
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::SwipeMode::Reveal")]
			[param: In]
			set;
		}
	}
}
