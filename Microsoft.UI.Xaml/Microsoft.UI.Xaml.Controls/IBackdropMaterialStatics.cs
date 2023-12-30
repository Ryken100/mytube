using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(1887381237u, 1069, 23462, 161, 200, 203, 198, 98, 70, 247, 161)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(BackdropMaterial))]
	[WebHostHidden]
	[MUXPropertyChangedCallback(enable = true)]
	internal interface IBackdropMaterialStatics
	{
		[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
		DependencyProperty ApplyToRootOrPageBackgroundProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnApplyToRootOrPageBackgroundChanged")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetApplyToRootOrPageBackground([In] Control element, [In] bool value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetApplyToRootOrPageBackground([In] Control element);
	}
}
