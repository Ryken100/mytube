using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Composable(typeof(INonVirtualizingLayoutFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public class NonVirtualizingLayout : Layout, INonVirtualizingLayout, INonVirtualizingLayoutOverrides
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern void InitializeForContextCore([In] NonVirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern void UninitializeForContextCore([In] NonVirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern Size MeasureOverride([In] NonVirtualizingLayoutContext context, [In] Size availableSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern Size ArrangeOverride([In] NonVirtualizingLayoutContext context, [In] Size finalSize);
	}
}
