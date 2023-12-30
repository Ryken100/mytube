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
	[ContentProperty(Name = "Items")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[Static(typeof(IMenuBarStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Composable(typeof(IMenuBarFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class MenuBar : Control, IMenuBar
	{
		public extern IList<MenuBarItem> Items
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty ItemsProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
