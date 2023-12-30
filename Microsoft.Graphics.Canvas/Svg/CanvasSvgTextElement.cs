using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000BA RID: 186
	[Version(167772160U)]
	[MarshalingBehavior(2)]
	[Threading(3)]
	public sealed class CanvasSvgTextElement : ICanvasSvgTextElement, IClosable
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600059D RID: 1437
		// (set) Token: 0x0600059C RID: 1436
		public extern string Text
		{
			get; [param: In]
			set;
		}

		// Token: 0x0600059E RID: 1438
		public extern void Close();
	}
}
