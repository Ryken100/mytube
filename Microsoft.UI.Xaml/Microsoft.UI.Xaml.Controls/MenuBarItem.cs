using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Static(typeof(IMenuBarItemStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[ContentProperty(Name = "Items")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Composable(typeof(IMenuBarItemFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536u)]
	public class MenuBarItem : Control, IMenuBarItem
	{
		public extern string Title
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public extern IList<MenuFlyoutItemBase> Items
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ItemsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty TitleProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
