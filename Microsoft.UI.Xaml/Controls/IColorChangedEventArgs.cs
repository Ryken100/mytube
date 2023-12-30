using System;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200008D RID: 141
	[ExclusiveTo(typeof(ColorChangedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(344807330U, 45515, 24413, 182, 181, 81, 40, 5, 215, 23, 97)]
	[WebHostHidden]
	internal interface IColorChangedEventArgs
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000196 RID: 406
		Color OldColor { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000197 RID: 407
		Color NewColor { get; }
	}
}
