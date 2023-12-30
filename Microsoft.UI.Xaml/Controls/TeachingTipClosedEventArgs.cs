using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000215 RID: 533
	[WebHostHidden]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public sealed class TeachingTipClosedEventArgs : ITeachingTipClosedEventArgs
	{
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06000B5C RID: 2908
		public extern TeachingTipCloseReason Reason { get; }
	}
}
