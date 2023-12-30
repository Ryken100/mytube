using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public sealed class NumberBoxValueChangedEventArgs : INumberBoxValueChangedEventArgs
	{
		public extern double NewValue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern double OldValue
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
