using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[ExclusiveTo(typeof(NumberBoxValueChangedEventArgs))]
	[Windows.Foundation.Metadata.Guid(3329028462u, 31882, 21294, 157, 35, 5, 140, 28, 152, 221, 80)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface INumberBoxValueChangedEventArgs
	{
		double OldValue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		double NewValue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
