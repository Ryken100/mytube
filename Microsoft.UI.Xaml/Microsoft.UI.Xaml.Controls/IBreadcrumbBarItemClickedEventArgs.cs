using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(485401859u, 13918, 22541, 188, 212, 233, 173, 2, 72, 246, 181)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(BreadcrumbBarItemClickedEventArgs))]
	internal interface IBreadcrumbBarItemClickedEventArgs
	{
		int Index
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		object Item
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
