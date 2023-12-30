using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Composable(typeof(ILayoutFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class Layout : DependencyObject, ILayout, ILayoutProtected
	{
		[method: In]
		public extern event TypedEventHandler<Layout, object> ArrangeInvalidated;

		[method: In]
		public extern event TypedEventHandler<Layout, object> MeasureInvalidated;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void InitializeForContext([In] LayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void UninitializeForContext([In] LayoutContext context);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern Size Measure([In] LayoutContext context, [In] Size availableSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern Size Arrange([In] LayoutContext context, [In] Size finalSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected extern void InvalidateMeasure();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected extern void InvalidateArrange();
	}
}
