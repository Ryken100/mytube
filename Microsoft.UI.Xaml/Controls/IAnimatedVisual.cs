using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Composition;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200007B RID: 123
	[Guid(2215643417U, 40469, 20742, 150, 71, 150, 84, 237, 227, 53, 222)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public interface IAnimatedVisual : IClosable
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600015C RID: 348
		Visual RootVisual { get; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600015D RID: 349
		Vector2 Size { get; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600015E RID: 350
		TimeSpan Duration { get; }
	}
}
