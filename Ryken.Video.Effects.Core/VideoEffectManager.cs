using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.Editing;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x0200000C RID: 12
	[MarshalingBehavior(2)]
	[Threading(3)]
	[Version(16777216U)]
	[Static(typeof(IVideoEffectManagerStatic), 16777216U)]
	public sealed class VideoEffectManager : IVideoEffectManagerClass, IStringable
	{
		// Token: 0x06000033 RID: 51
		public static extern void AddFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties, [In] FrameworkElement container);

		// Token: 0x06000034 RID: 52
		[Overload("AddVideoEffect1")]
		public static extern void AddVideoEffect([In] MediaClip mediaClip, [In] string id, [In] IPropertySet properties);

		// Token: 0x06000035 RID: 53
		[DefaultOverload]
		[Overload("AddVideoEffect2")]
		public static extern void AddVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties);

		// Token: 0x06000036 RID: 54
		[Overload("AddVideoEffect3")]
		public static extern void AddVideoEffect([In] MediaElement mediaElement, [In] string id, [In] IPropertySet properties);

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000037 RID: 55
		public static extern string IDKey { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000038 RID: 56
		public static extern string InstanceIDKey { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000039 RID: 57
		public static extern string VideoEffectClassId { get; }

		// Token: 0x0600003A RID: 58
		public static extern bool ProcessFrame([In] IVideoEffectHandlerArgs args);

		// Token: 0x0600003B RID: 59
		public static extern void RegisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);

		// Token: 0x0600003C RID: 60
		public static extern void RemoveDrawingSessionTransform([In] string id);

		// Token: 0x0600003D RID: 61
		[Overload("RemoveFrameServerVideoEffect1")]
		public static extern void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer);

		// Token: 0x0600003E RID: 62
		[Overload("RemoveFrameServerVideoEffect2")]
		public static extern void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id);

		// Token: 0x0600003F RID: 63
		public static extern void SetDrawingSessionTransform([In] string id, [In] TransformType type, [In] Vector2 targetSize);

		// Token: 0x06000040 RID: 64
		[Overload("UnregisterVideoEffectHandler1")]
		public static extern void UnregisterVideoEffectHandler([In] IVideoEffectHandler handler);

		// Token: 0x06000041 RID: 65
		[Overload("UnregisterVideoEffectHandler2")]
		public static extern void UnregisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);

		// Token: 0x06000042 RID: 66
		string IStringable.ToString();
	}
}
