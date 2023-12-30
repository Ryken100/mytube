using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(460083196u, 52530, 24070, 183, 130, 223, 159, 7, 117, 70, 199)]
	[ExclusiveTo(typeof(TreeViewDragItemsStartingEventArgs))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface ITreeViewDragItemsStartingEventArgs
	{
		bool Cancel
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		DataPackage Data
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		IList<object> Items
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
