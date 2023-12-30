using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ExclusiveTo(typeof(TreeView))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Windows.Foundation.Metadata.Guid(468687604u, 28972, 20719, 155, 180, 136, 27, 151, 82, 50, 171)]
	[WebHostHidden]
	internal interface ITreeView
	{
		IList<TreeViewNode> RootNodes
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
		[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
		TreeViewSelectionMode SelectionMode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::TreeViewSelectionMode::Single")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		IList<TreeViewNode> SelectedNodes
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Expand([In] TreeViewNode value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Collapse([In] TreeViewNode value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SelectAll();

		event TypedEventHandler<TreeView, TreeViewItemInvokedEventArgs> ItemInvoked;

		event TypedEventHandler<TreeView, TreeViewExpandingEventArgs> Expanding;

		event TypedEventHandler<TreeView, TreeViewCollapsedEventArgs> Collapsed;
	}
}
