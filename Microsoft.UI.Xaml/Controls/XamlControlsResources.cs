using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x02000232 RID: 562
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[Static(typeof(IXamlControlsResourcesStatics), 65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[Static(typeof(IXamlControlsResourcesStatics3), 131072U, "Microsoft.UI.Xaml.XamlContract")]
	[Threading(3)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[MUXPropertyChangedCallback(enable = true)]
	[WebHostHidden]
	public sealed class XamlControlsResources : ResourceDictionary, IXamlControlsResources, IXamlControlsResources3
	{
		// Token: 0x06000C34 RID: 3124
		public extern XamlControlsResources();

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06000C35 RID: 3125
		// (set) Token: 0x06000C36 RID: 3126
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
		public extern ControlsResourcesVersion ControlsResourcesVersion
		{
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			get;
			[MUXPropertyDefaultValue(value = "winrt::ControlsResourcesVersion::Version2")]
			[param: In]
			set;
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06000C37 RID: 3127
		public static extern DependencyProperty ControlsResourcesVersionProperty { get; }

		// Token: 0x06000C38 RID: 3128
		public static extern void EnsureRevealLights([In] UIElement element);
	}
}
