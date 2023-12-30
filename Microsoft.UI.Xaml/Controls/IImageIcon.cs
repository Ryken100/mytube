using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A5 RID: 165
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(3809246316U, 8230, 24182, 162, 113, 27, 159, 171, 63, 132, 157)]
	[ExclusiveTo(typeof(ImageIcon))]
	internal interface IImageIcon
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000215 RID: 533
		// (set) Token: 0x06000216 RID: 534
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		ImageSource Source
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
