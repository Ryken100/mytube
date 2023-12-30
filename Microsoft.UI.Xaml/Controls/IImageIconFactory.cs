using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000A6 RID: 166
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ImageIcon))]
	[Guid(593363577U, 42960, 24538, 163, 8, 155, 124, 185, 196, 201, 18)]
	[WebHostHidden]
	internal interface IImageIconFactory
	{
		// Token: 0x06000217 RID: 535
		ImageIcon CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
