using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000098 RID: 152
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	[Guid(3342360867U, 28985, 20636, 136, 107, 157, 116, 203, 169, 86, 222)]
	[ExclusiveTo(typeof(ElementFactoryRecycleArgs))]
	internal interface IElementFactoryRecycleArgs
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001E0 RID: 480
		// (set) Token: 0x060001E1 RID: 481
		UIElement Element
		{
			get; [param: In]
			set;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001E2 RID: 482
		// (set) Token: 0x060001E3 RID: 483
		UIElement Parent
		{
			get; [param: In]
			set;
		}
	}
}
