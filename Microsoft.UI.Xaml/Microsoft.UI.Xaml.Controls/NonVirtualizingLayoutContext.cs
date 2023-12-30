using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Composable(typeof(INonVirtualizingLayoutContextFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Threading(ThreadingModel.Both)]
	public class NonVirtualizingLayoutContext : LayoutContext, INonVirtualizingLayoutContext, INonVirtualizingLayoutContextOverrides
	{
		public extern IReadOnlyList<UIElement> Children
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		protected virtual extern IReadOnlyList<UIElement> ChildrenCore
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
