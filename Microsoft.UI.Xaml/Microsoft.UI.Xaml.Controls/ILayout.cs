using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(618990620u, 40017, 20804, 157, 220, 63, 80, 1, 145, 194, 98)]
	[WebHostHidden]
	[ExclusiveTo(typeof(Layout))]
	internal interface ILayout
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InitializeForContext([In] LayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UninitializeForContext([In] LayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Size Measure([In] LayoutContext context, [In] Size availableSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Size Arrange([In] LayoutContext context, [In] Size finalSize);

		event TypedEventHandler<Layout, object> MeasureInvalidated;

		event TypedEventHandler<Layout, object> ArrangeInvalidated;
	}
}
