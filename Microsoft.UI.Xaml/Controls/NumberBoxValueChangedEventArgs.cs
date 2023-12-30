using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020001AD RID: 429
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class NumberBoxValueChangedEventArgs : INumberBoxValueChangedEventArgs
	{
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000834 RID: 2100
		public extern double OldValue { get; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000835 RID: 2101
		public extern double NewValue { get; }
	}
}
