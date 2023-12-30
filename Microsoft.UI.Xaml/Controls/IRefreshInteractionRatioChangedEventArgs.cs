using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000121 RID: 289
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2030792928U, 61849, 21803, 177, 38, 108, 180, 92, 45, 232, 249)]
	[ExclusiveTo(typeof(RefreshInteractionRatioChangedEventArgs))]
	[WebHostHidden]
	internal interface IRefreshInteractionRatioChangedEventArgs
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060004B8 RID: 1208
		double InteractionRatio { get; }
	}
}
