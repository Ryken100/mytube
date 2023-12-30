using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallback(enable = true)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(IBackdropMaterialFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Static(typeof(IBackdropMaterialStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class BackdropMaterial : DependencyObject, IBackdropMaterial
	{
		[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
		public static extern DependencyProperty ApplyToRootOrPageBackgroundProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetApplyToRootOrPageBackground([In] Control element, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool GetApplyToRootOrPageBackground([In] Control element);
	}
}
