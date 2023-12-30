using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000091 RID: 145
	[ExclusiveTo(typeof(CommandBarFlyout))]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Guid(4176853180U, 36199, 24489, 143, 176, 194, 195, 49, 30, 27, 124)]
	[WebHostHidden]
	internal interface ICommandBarFlyout
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001D4 RID: 468
		IObservableVector<ICommandBarElement> PrimaryCommands { get; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001D5 RID: 469
		IObservableVector<ICommandBarElement> SecondaryCommands { get; }
	}
}
