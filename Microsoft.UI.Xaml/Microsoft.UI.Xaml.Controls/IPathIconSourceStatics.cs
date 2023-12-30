using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(PathIconSource))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(480365042u, 11923, 22647, 182, 64, 131, 97, 66, 194, 250, 192)]
	internal interface IPathIconSourceStatics
	{
		DependencyProperty DataProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
