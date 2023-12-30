using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2750207101u, 10610, 23833, 166, 46, 221, 251, 197, 225, 173, 87)]
	[ExclusiveTo(typeof(TeachingTip))]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITeachingTipFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		TeachingTip CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
