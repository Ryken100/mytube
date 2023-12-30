using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(1254919340u, 48296, 21376, 149, 228, 52, 92, 27, 226, 86, 178)]
	[ExclusiveTo(typeof(RatingItemImageInfo))]
	internal interface IRatingItemImageInfoFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		RatingItemImageInfo CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
