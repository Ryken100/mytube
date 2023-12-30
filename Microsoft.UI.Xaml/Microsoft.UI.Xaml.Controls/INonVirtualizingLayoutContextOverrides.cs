using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(NonVirtualizingLayoutContext))]
	[Windows.Foundation.Metadata.Guid(4174665887u, 45963, 23561, 131, 86, 199, 62, 207, 182, 238, 216)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INonVirtualizingLayoutContextOverrides
	{
		IReadOnlyList<UIElement> ChildrenCore
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
