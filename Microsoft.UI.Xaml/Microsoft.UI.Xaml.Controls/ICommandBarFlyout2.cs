using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 131072u)]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(1602350238u, 43474, 24324, 181, 177, 1, 61, 174, 240, 38, 221)]
	[ExclusiveTo(typeof(CommandBarFlyout))]
	internal interface ICommandBarFlyout2
	{
		bool AlwaysExpanded
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}
	}
}
