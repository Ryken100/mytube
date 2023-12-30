using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(4255583812u, 25894, 21813, 190, 43, 236, 39, 67, 103, 10, 226)]
	[WebHostHidden]
	[ExclusiveTo(typeof(LayoutContext))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ILayoutContextOverrides
	{
		object LayoutStateCore
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
