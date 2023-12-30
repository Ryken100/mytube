using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(195674555u, 25884, 24419, 188, 187, 123, 223, 231, 75, 123, 56)]
	[WebHostHidden]
	[ExclusiveTo(typeof(NonVirtualizingLayoutContext))]
	internal interface INonVirtualizingLayoutContext
	{
		IReadOnlyList<UIElement> Children
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
