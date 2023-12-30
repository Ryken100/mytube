using System;
using System.Runtime.InteropServices;
using Microsoft.Graphics.Canvas;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x02000008 RID: 8
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Activatable(typeof(IVideoEffectHandlerArgsFactory), 16777216U)]
	public sealed class VideoEffectHandlerArgs : IVideoEffectHandlerArgs, ITransformableVideoEffectHandlerArgs, IStringable
	{
		// Token: 0x0600001D RID: 29
		public extern VideoEffectHandlerArgs([In] CanvasDevice device, [In] CanvasBitmap inputFrame, [In] CanvasRenderTarget outputFrame, [In] string id, [In] string instanceId, [In] IPropertySet properties, [In] IReference<TimeSpan> position);

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001E RID: 30
		public extern CanvasBitmap InputFrame { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001F RID: 31
		public extern CanvasRenderTarget OutputFrame { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000020 RID: 32
		public extern CanvasDevice Device { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000021 RID: 33
		public extern string ID { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000022 RID: 34
		public extern IPropertySet Properties { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000023 RID: 35
		public extern string InstanceID { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000024 RID: 36
		public extern IReference<TimeSpan> Position { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000025 RID: 37
		public extern Matrix3x2 Transform { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000026 RID: 38
		public extern Size OutputSize { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000027 RID: 39
		public extern Rect OutputBounds { get; }

		// Token: 0x06000028 RID: 40
		void ITransformableVideoEffectHandlerArgs.SetTransform([In] Matrix3x2 transform, [In] Vector2 outputSize);

		// Token: 0x06000029 RID: 41
		public extern CanvasDrawingSession CreateDrawingSession();

		// Token: 0x0600002A RID: 42
		string IStringable.ToString();
	}
}
