using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[Threading(ThreadingModel.Both)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Static(typeof(ITabViewItemTemplateSettingsStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Composable(typeof(ITabViewItemTemplateSettingsFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class TabViewItemTemplateSettings : DependencyObject, ITabViewItemTemplateSettings
	{
		public extern IconElement IconElement
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[param: In]
			set;
		}

		public static extern DependencyProperty IconElementProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
