using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls.Primitives
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[WebHostHidden]
	[Composable(typeof(INavigationViewItemPresenterTemplateSettingsFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(INavigationViewItemPresenterTemplateSettingsStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class NavigationViewItemPresenterTemplateSettings : DependencyObject, INavigationViewItemPresenterTemplateSettings
	{
		public extern double IconWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public extern double SmallerIconWidth
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty IconWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty SmallerIconWidthProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
