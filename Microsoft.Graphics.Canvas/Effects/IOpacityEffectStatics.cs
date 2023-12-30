using System;
using Windows.Foundation.Metadata;

namespace Microsoft.Graphics.Canvas.Effects
{
	// Token: 0x02000158 RID: 344
	[Version(167772160U)]
	[Guid(2443693539U, 47543, 21559, 136, 120, 251, 46, 20, 16, 14, 109)]
	[ExclusiveTo(typeof(OpacityEffect))]
	internal interface IOpacityEffectStatics
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000D80 RID: 3456
		bool IsSupported { get; }
	}
}
