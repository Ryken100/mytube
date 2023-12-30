using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Threading(ThreadingModel.Both)]
	[Composable(typeof(IVirtualizingLayoutFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class VirtualizingLayout : Layout, IVirtualizingLayout, IVirtualizingLayoutOverrides
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern void InitializeForContextCore([In] VirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern void UninitializeForContextCore([In] VirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern Size MeasureOverride([In] VirtualizingLayoutContext context, [In] Size availableSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern Size ArrangeOverride([In] VirtualizingLayoutContext context, [In] Size finalSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern void OnItemsChangedCore([In] VirtualizingLayoutContext context, [In] object source, [In] NotifyCollectionChangedEventArgs args);
	}
}
