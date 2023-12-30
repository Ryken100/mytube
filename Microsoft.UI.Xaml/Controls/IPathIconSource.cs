using System;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x020000F8 RID: 248
	[Guid(1015625070U, 2593, 24158, 162, 186, 216, 131, 115, 101, 20, 59)]
	[ExclusiveTo(typeof(PathIconSource))]
	[WebHostHidden]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	internal interface IPathIconSource
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060003D4 RID: 980
		// (set) Token: 0x060003D5 RID: 981
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		Geometry Data
		{
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}
	}
}
