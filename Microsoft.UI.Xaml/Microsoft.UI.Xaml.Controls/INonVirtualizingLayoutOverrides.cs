using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(NonVirtualizingLayout))]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1009301553u, 13761, 20866, 168, 67, 164, 63, 51, 155, 102, 135)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INonVirtualizingLayoutOverrides
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InitializeForContextCore([In] NonVirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UninitializeForContextCore([In] NonVirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Size MeasureOverride([In] NonVirtualizingLayoutContext context, [In] Size availableSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Size ArrangeOverride([In] NonVirtualizingLayoutContext context, [In] Size finalSize);
	}
}
