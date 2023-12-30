using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[WebHostHidden]
	[Windows.Foundation.Metadata.Guid(3212806245u, 31609, 21332, 151, 136, 194, 30, 82, 53, 145, 234)]
	[ExclusiveTo(typeof(AnimatedVisualPlayer))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IAnimatedVisualPlayer
	{
		object Diagnostics
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		TimeSpan Duration
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		IAnimatedVisualSource Source
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		DataTemplate FallbackContent
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		bool AutoPlay
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		bool IsAnimatedVisualLoaded
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		bool IsPlaying
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "1")]
		[MUXPropertyChangedCallback(enable = true)]
		double PlaybackRate
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "1")]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		CompositionObject ProgressObject
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
		[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		Stretch Stretch
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "winrt::Stretch::Uniform")]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Pause();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IAsyncAction PlayAsync([In] double fromProgress, [In] double toProgress, [In] bool looped);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Resume();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetProgress([In] double progress);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Stop();
	}
}
