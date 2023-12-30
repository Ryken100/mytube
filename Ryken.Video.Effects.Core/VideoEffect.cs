using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x02000007 RID: 7
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(16777216U)]
	public sealed class VideoEffect : IBasicVideoEffect, IMediaExtension, IStringable
	{
		// Token: 0x06000012 RID: 18
		public extern VideoEffect();

		// Token: 0x06000013 RID: 19
		public extern void SetEncodingProperties([In] VideoEncodingProperties encodingProperties, [In] IDirect3DDevice device);

		// Token: 0x06000014 RID: 20
		public extern void ProcessFrame([In] ProcessVideoFrameContext context);

		// Token: 0x06000015 RID: 21
		public extern void Close([In] MediaEffectClosedReason reason);

		// Token: 0x06000016 RID: 22
		public extern void DiscardQueuedFrames();

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000017 RID: 23
		public extern bool IsReadOnly { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000018 RID: 24
		public extern IVectorView<VideoEncodingProperties> SupportedEncodingProperties { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000019 RID: 25
		public extern MediaMemoryTypes SupportedMemoryTypes { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001A RID: 26
		public extern bool TimeIndependent { get; }

		// Token: 0x0600001B RID: 27
		public extern void SetProperties([In] IPropertySet configuration);

		// Token: 0x0600001C RID: 28
		string IStringable.ToString();
	}
}
