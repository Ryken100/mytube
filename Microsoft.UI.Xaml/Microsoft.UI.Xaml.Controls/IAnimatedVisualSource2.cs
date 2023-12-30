using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(440095655u, 43262, 22945, 181, 68, 67, 164, 217, 200, 30, 242)]
	public interface IAnimatedVisualSource2 : IAnimatedVisualSource
	{
		IReadOnlyDictionary<string, double> Markers
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetColorProperty([In] string propertyName, [In] Color value);
	}
}
