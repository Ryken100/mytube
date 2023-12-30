using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200007D RID: 125
	[WebHostHidden]
	[ExclusiveTo(typeof(AnimatedVisualPlayer))]
	[Guid(3955279590U, 51482, 20517, 180, 164, 231, 134, 216, 59, 225, 216)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	internal interface IAnimatedVisualPlayerFactory
	{
		// Token: 0x06000173 RID: 371
		AnimatedVisualPlayer CreateInstance([In] object baseInterface, out object innerInterface);
	}
}
