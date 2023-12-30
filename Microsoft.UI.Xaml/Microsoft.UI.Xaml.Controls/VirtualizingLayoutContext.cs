using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[Composable(typeof(IVirtualizingLayoutContextFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class VirtualizingLayoutContext : LayoutContext, IVirtualizingLayoutContext, IVirtualizingLayoutContextOverrides
	{
		public extern Point LayoutOrigin
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern int ItemCount
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern Rect RealizationRect
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern int RecommendedAnchorIndex
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		protected virtual extern Point LayoutOriginCore
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		protected virtual extern int RecommendedAnchorIndexCore
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern object GetItemAt([In] int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetOrCreateElementAt")]
		public extern UIElement GetOrCreateElementAt([In] int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("GetOrCreateElementAt2")]
		public extern UIElement GetOrCreateElementAt([In] int index, [In] ElementRealizationOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern void RecycleElement([In] UIElement element);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern int ItemCountCore();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern object GetItemAtCore([In] int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern Rect RealizationRectCore();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern UIElement GetOrCreateElementAtCore([In] int index, [In] ElementRealizationOptions options);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		protected virtual extern void RecycleElementCore([In] UIElement element);
	}
}
