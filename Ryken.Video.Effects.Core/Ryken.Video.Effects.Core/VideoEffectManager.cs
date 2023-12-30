using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Editing;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[MarshalingBehavior(MarshalingType.Agile)]
	[Threading(ThreadingModel.Both)]
	[Version(16777216u)]
	[Static(typeof(IVideoEffectManagerStatic), 16777216u)]
	public sealed class VideoEffectManager : IVideoEffectManagerClass, IStringable
	{
		public static extern string VideoEffectClassId
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern string IDKey
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern string InstanceIDKey
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void AddFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties, [In] FrameworkElement container);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddVideoEffect1")]
		public static extern void AddVideoEffect([In] MediaClip mediaClip, [In] string id, [In] IPropertySet properties);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("AddVideoEffect2")]
		public static extern void AddVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddVideoEffect3")]
		public static extern void AddVideoEffect([In] MediaElement mediaElement, [In] string id, [In] IPropertySet properties);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern bool ProcessFrame([In] IVideoEffectHandlerArgs args);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void RegisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void RemoveDrawingSessionTransform([In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("RemoveFrameServerVideoEffect1")]
		public static extern void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("RemoveFrameServerVideoEffect2")]
		public static extern void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public static extern void SetDrawingSessionTransform([In] string id, [In] TransformType type, [In] Vector2 targetSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("UnregisterVideoEffectHandler1")]
		public static extern void UnregisterVideoEffectHandler([In] IVideoEffectHandler handler);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("UnregisterVideoEffectHandler2")]
		public static extern void UnregisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		extern string IStringable.ToString();
	}
}
