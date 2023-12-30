using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000084 RID: 132
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ExclusiveTo(typeof(BitmapIconSource))]
	[Guid(2796997836U, 60047, 21450, 131, 31, 42, 190, 133, 205, 109, 140)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IBitmapIconSource
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000183 RID: 387
		// (set) Token: 0x06000184 RID: 388
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		Uri UriSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000185 RID: 389
		// (set) Token: 0x06000186 RID: 390
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		bool ShowAsMonochrome
		{
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
