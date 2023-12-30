using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000083 RID: 131
	[Guid(1887381237U, 1069, 23462, 161, 200, 203, 198, 98, 70, 247, 161)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[ExclusiveTo(typeof(BackdropMaterial))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IBackdropMaterialStatics
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000180 RID: 384
		[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
		DependencyProperty ApplyToRootOrPageBackgroundProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
			get;
		}

		// Token: 0x06000181 RID: 385
		void SetApplyToRootOrPageBackground([In] Control element, [In] bool value);

		// Token: 0x06000182 RID: 386
		bool GetApplyToRootOrPageBackground([In] Control element);
	}
}
