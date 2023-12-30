using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(2985540512u, 4238, 22029, 150, 129, 38, 57, 27, 75, 195, 13)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	public interface IKeyIndexMapping
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string KeyFromIndex([In] int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int IndexFromKey([In] string key);
	}
}
