using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(NumberBox))]
	[Windows.Foundation.Metadata.Guid(1803678667u, 17828, 23833, 155, 187, 169, 254, 70, 86, 172, 77)]
	internal interface INumberBoxFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		NumberBox CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
