using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1643197568u, 52492, 21866, 181, 50, 160, 207, 83, 227, 205, 160)]
	[ExclusiveTo(typeof(RatingItemInfo))]
	internal interface IRatingItemInfoFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RatingItemInfo CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
