using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200005F RID: 95
	[MUXPropertyChangedCallback(enable = true)]
	[MarshalingBehavior(2)]
	[Composable(typeof(IBackdropMaterialFactory), 2, 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(IBackdropMaterialStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	public class BackdropMaterial : DependencyObject, IBackdropMaterial
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B4 RID: 180
		[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
		public static extern DependencyProperty ApplyToRootOrPageBackgroundProperty
		{
			[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
			get;
		}

		// Token: 0x060000B5 RID: 181
		public static extern void SetApplyToRootOrPageBackground([In] Control element, [In] bool value);

		// Token: 0x060000B6 RID: 182
		public static extern bool GetApplyToRootOrPageBackground([In] Control element);
	}
}
