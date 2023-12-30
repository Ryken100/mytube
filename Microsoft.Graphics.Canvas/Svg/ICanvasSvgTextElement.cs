using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Svg
{
	// Token: 0x020000BB RID: 187
	[ExclusiveTo(typeof(CanvasSvgTextElement))]
	[Guid(1697089192U, 62379, 16515, 153, 29, 151, 72, 170, 134, 189, 109)]
	[Version(167772160U)]
	internal interface ICanvasSvgTextElement : IClosable
	{
		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060005A0 RID: 1440
		// (set) Token: 0x0600059F RID: 1439
		string Text
		{
			get; [param: In]
			set;
		}
	}
}
