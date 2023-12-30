using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(4160226014u, 59292, 23647, 171, 248, 204, 189, 72, 107, 137, 214)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[ExclusiveTo(typeof(ItemsSourceView))]
	[WebHostHidden]
	internal interface IItemsSourceView
	{
		int Count
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		object GetAt([In] int index);

		bool HasKeyIndexMapping
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string KeyFromIndex([In] int index);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int IndexFromKey([In] string key);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int IndexOf([In] object item);
	}
}
