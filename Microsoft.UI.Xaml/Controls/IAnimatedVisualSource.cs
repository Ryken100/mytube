using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200007F RID: 127
	[WebHostHidden]
	[Guid(1471113486U, 45873, 21602, 140, 198, 197, 41, 165, 218, 65, 35)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	public interface IAnimatedVisualSource
	{
		// Token: 0x0600017D RID: 381
		IAnimatedVisual TryCreateAnimatedVisual([In] Compositor compositor, out object diagnostics);
	}
}
