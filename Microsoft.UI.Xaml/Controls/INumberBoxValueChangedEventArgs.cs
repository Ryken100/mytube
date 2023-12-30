using System;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F4 RID: 244
	[WebHostHidden]
	[ExclusiveTo(typeof(NumberBoxValueChangedEventArgs))]
	[Guid(3329028462U, 31882, 21294, 157, 35, 5, 140, 28, 152, 221, 80)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface INumberBoxValueChangedEventArgs
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060003A5 RID: 933
		double OldValue { get; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060003A6 RID: 934
		double NewValue { get; }
	}
}
