using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3650711326u, 25278, 20830, 132, 61, 8, 53, 6, 223, 62, 125)]
	[ExclusiveTo(typeof(VirtualizingLayout))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IVirtualizingLayoutOverrides
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InitializeForContextCore([In] VirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UninitializeForContextCore([In] VirtualizingLayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Size MeasureOverride([In] VirtualizingLayoutContext context, [In] Size availableSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Size ArrangeOverride([In] VirtualizingLayoutContext context, [In] Size finalSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void OnItemsChangedCore([In] VirtualizingLayoutContext context, [In] object source, [In] NotifyCollectionChangedEventArgs args);
	}
}
