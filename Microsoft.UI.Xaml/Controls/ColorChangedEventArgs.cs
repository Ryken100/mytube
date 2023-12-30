using System;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000064 RID: 100
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MarshalingBehavior(2)]
	[WebHostHidden]
	public sealed class ColorChangedEventArgs : IColorChangedEventArgs
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000CA RID: 202
		public extern Color OldColor { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CB RID: 203
		public extern Color NewColor { get; }
	}
}
