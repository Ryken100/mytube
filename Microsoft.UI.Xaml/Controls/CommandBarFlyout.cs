using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000069 RID: 105
	[Threading(3)]
	[MarshalingBehavior(2)]
	[Composable(typeof(ICommandBarFlyoutFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[ContentProperty(Name = "PrimaryCommands")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public class CommandBarFlyout : FlyoutBase, ICommandBarFlyout, ICommandBarFlyout2
	{
		// Token: 0x06000108 RID: 264
		public extern CommandBarFlyout();

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000109 RID: 265
		public extern IObservableVector<ICommandBarElement> PrimaryCommands { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600010A RID: 266
		public extern IObservableVector<ICommandBarElement> SecondaryCommands { get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600010B RID: 267
		// (set) Token: 0x0600010C RID: 268
		public extern bool AlwaysExpanded
		{
			get; [param: In]
			set;
		}
	}
}
