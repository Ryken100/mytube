using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(TeachingTipClosedEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Windows.Foundation.Metadata.Guid(624358662u, 16440, 23003, 158, 53, 169, 37, 47, 181, 173, 178)]
	internal interface ITeachingTipClosedEventArgs
	{
		TeachingTipCloseReason Reason
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
