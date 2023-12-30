using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A7 RID: 167
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3347699724U, 1172, 21694, 185, 65, 117, 125, 63, 114, 48, 3)]
	[ExclusiveTo(typeof(ImageIconSource))]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IImageIconSource
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000218 RID: 536
		// (set) Token: 0x06000219 RID: 537
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		ImageSource ImageSource
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
