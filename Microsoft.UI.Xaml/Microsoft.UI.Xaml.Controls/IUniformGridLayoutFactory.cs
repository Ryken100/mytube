using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallback(enable = true)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(228513800u, 62457, 20532, 150, 39, 21, 43, 145, 233, 27, 75)]
	[ExclusiveTo(typeof(UniformGridLayout))]
	[WebHostHidden]
	internal interface IUniformGridLayoutFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		UniformGridLayout CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
