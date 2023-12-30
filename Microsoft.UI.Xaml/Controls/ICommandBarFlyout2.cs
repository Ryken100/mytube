using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000092 RID: 146
	[ContractVersion(typeof(XamlContract), 131072U)]
	[WebHostHidden]
	[Guid(1602350238U, 43474, 24324, 181, 177, 1, 61, 174, 240, 38, 221)]
	[ExclusiveTo(typeof(CommandBarFlyout))]
	internal interface ICommandBarFlyout2
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001D6 RID: 470
		// (set) Token: 0x060001D7 RID: 471
		bool AlwaysExpanded
		{
			get; [param: In]
			set;
		}
	}
}
