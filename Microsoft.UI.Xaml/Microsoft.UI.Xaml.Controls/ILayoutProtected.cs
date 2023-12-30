using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(Layout))]
	[Windows.Foundation.Metadata.Guid(3832542230u, 29726, 20854, 161, 212, 87, 24, 210, 52, 34, 67)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	internal interface ILayoutProtected
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InvalidateMeasure();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void InvalidateArrange();
	}
}
