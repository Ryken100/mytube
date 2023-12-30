using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Editing;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Ryken.Video.Effects.Core
{
	[ComImport]
	[Windows.Foundation.Metadata.Guid(3708629852u, 40144, 21141, 78, 117, 159, 47, 10, 177, 172, 24)]
	[Version(16777216u)]
	[ExclusiveTo(typeof(VideoEffectManager))]
	internal interface IVideoEffectManagerStatic
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void AddFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties, [In] FrameworkElement container);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddVideoEffect1")]
		void AddVideoEffect([In] MediaClip mediaClip, [In] string id, [In] IPropertySet properties);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DefaultOverload]
		[Overload("AddVideoEffect2")]
		void AddVideoEffect([In] MediaPlayer mediaPlayer, [In] string id, [In] IPropertySet properties);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("AddVideoEffect3")]
		void AddVideoEffect([In] MediaElement mediaElement, [In] string id, [In] IPropertySet properties);

		string IDKey
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		string InstanceIDKey
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		string VideoEffectClassId
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool ProcessFrame([In] IVideoEffectHandlerArgs args);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RegisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RemoveDrawingSessionTransform([In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("RemoveFrameServerVideoEffect1")]
		void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("RemoveFrameServerVideoEffect2")]
		void RemoveFrameServerVideoEffect([In] MediaPlayer mediaPlayer, [In] string id);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetDrawingSessionTransform([In] string id, [In] TransformType type, [In] Vector2 targetSize);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("UnregisterVideoEffectHandler1")]
		void UnregisterVideoEffectHandler([In] IVideoEffectHandler handler);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[Overload("UnregisterVideoEffectHandler2")]
		void UnregisterVideoEffectHandler([In] string id, [In] IVideoEffectHandler handler);
	}
}
