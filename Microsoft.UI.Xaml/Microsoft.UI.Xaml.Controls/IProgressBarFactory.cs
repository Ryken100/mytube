using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(412624557u, 63218, 21310, 157, 219, 182, 96, 14, 136, 103, 91)]
	[ExclusiveTo(typeof(ProgressBar))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IProgressBarFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ProgressBar CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
