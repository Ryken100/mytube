using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000123 RID: 291
	[ExclusiveTo(typeof(RefreshStateChangedEventArgs))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(2078840782U, 6084, 24543, 180, 65, 198, 239, 51, 1, 224, 246)]
	internal interface IRefreshStateChangedEventArgs
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060004BA RID: 1210
		RefreshVisualizerState OldState { get; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060004BB RID: 1211
		RefreshVisualizerState NewState { get; }
	}
}
