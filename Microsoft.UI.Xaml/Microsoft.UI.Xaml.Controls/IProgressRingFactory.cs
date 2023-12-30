using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(154118540u, 25255, 23996, 154, 133, 62, 85, 107, 168, 31, 121)]
	[ExclusiveTo(typeof(ProgressRing))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IProgressRingFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ProgressRing CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
