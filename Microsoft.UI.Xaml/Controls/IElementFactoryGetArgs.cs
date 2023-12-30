using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000097 RID: 151
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(ElementFactoryGetArgs))]
	[WebHostHidden]
	[Guid(2425852366U, 8509, 20597, 162, 60, 191, 228, 108, 22, 179, 77)]
	internal interface IElementFactoryGetArgs
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001DC RID: 476
		// (set) Token: 0x060001DD RID: 477
		object Data
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001DE RID: 478
		// (set) Token: 0x060001DF RID: 479
		UIElement Parent
		{
			get; [param: In]
			set;
		}
	}
}
