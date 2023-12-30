using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Static(typeof(IXamlControlsResourcesStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Activatable(65536u, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IXamlControlsResourcesStatics3), 131072u, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(ThreadingModel.Both)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	public sealed class XamlControlsResources : ResourceDictionary, IXamlControlsResources, IXamlControlsResources3
	{
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		public extern ControlsResourcesVersion ControlsResourcesVersion
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			[param: In]
			set;
		}

		public static extern DependencyProperty ControlsResourcesVersionProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void EnsureRevealLights([In] UIElement element);
	}
}
