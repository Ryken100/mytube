using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(AnimatedVisualPlayer))]
	[Windows.Foundation.Metadata.Guid(3955279590u, 51482, 20517, 180, 164, 231, 134, 216, 59, 225, 216)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IAnimatedVisualPlayerFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		AnimatedVisualPlayer CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
