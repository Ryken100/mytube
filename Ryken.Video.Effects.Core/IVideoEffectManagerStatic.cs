using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Media.Editing;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Ryken.Video.Effects.Core
{
	// Token: 0x0200000D RID: 13
	[Guid(3708629852U, 40144, 21141, 78, 117, 159, 47, 10, 177, 172, 24)]
	[Version(16777216U)]
	[ExclusiveTo(typeof(VideoEffectManager))]
	internal interface IVideoEffectManagerStatic
	{
		// Token: 0x06000043 RID: 67
		void AddFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties, [In] FrameworkElement container);

		// Token: 0x06000044 RID: 68
		[Overload("AddVideoEffect1")]
		void AddVideoEffect([In] MediaClip mediaClip, [In] string id, [In] IPropertySet properties);

		// Token: 0x06000045 RID: 69
		[DefaultOverload]
		[Overload("AddVideoEffect2")]
		void AddVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties);

		// Token: 0x06000046 RID: 70
		[Overload("AddVideoEffect3")]
		void AddVideoEffect([In] MediaElement mediaElement, [In] string id, [In] IPropertySet properties);

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000047 RID: 71
		string IDKey { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000048 RID: 72
		string InstanceIDKey { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000049 RID: 73
		string VideoEffectClassId { get; }

		// Token: 0x0600004A RID: 74
		bool ProcessFrame([In] IVideoEffectHandlerArgs args);

		// Token: 0x0600004B RID: 75
		void RegisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);

		// Token: 0x0600004C RID: 76
		void RemoveDrawingSessionTransform([In] string id);

		// Token: 0x0600004D RID: 77
		[Overload("RemoveFrameServerVideoEffect1")]
		void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer);

		// Token: 0x0600004E RID: 78
		[Overload("RemoveFrameServerVideoEffect2")]
		void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id);

		// Token: 0x0600004F RID: 79
		void SetDrawingSessionTransform([In] string id, [In] TransformType type, [In] Vector2 targetSize);

		// Token: 0x06000050 RID: 80
		[Overload("UnregisterVideoEffectHandler1")]
		void UnregisterVideoEffectHandler([In] IVideoEffectHandler handler);

		// Token: 0x06000051 RID: 81
		[Overload("UnregisterVideoEffectHandler2")]
		void UnregisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);
	}
}
