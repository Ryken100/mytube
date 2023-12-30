using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	// Token: 0x0200006C RID: 108
	[Threading(3)]
	[Activatable(65536U, "Microsoft.UI.Xaml.XamlContract")]
	[MarshalingBehavior(2)]
	[ContractVersion(typeof(XamlContract), 65536U)]
	[WebHostHidden]
	public sealed class ElementFactoryGetArgs : IElementFactoryGetArgs
	{
		// Token: 0x0600010E RID: 270
		public extern ElementFactoryGetArgs();

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600010F RID: 271
		// (set) Token: 0x06000110 RID: 272
		public extern object Data
		{
			get; [param: In]
			set;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000111 RID: 273
		// (set) Token: 0x06000112 RID: 274
		public extern UIElement Parent
		{
			get; [param: In]
			set;
		}
	}
}
