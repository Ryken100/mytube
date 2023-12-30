using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyChangedCallbackMethodName(value = "OnPropertyChanged")]
	[Static(typeof(IBitmapIconSourceStatics), 65536u, "Microsoft.UI.Xaml.XamlContract")]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Threading(ThreadingModel.Both)]
	[MarshalingBehavior(MarshalingType.Agile)]
	[WebHostHidden]
	[Composable(typeof(IBitmapIconSourceFactory), CompositionType.Public, 65536u, "Microsoft.UI.Xaml.XamlContract")]
	public class BitmapIconSource : IconSource, IBitmapIconSource
	{
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyChangedCallback(enable = true)]
		public extern Uri UriSource
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[param: In]
			set;
		}

		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		[MUXPropertyDefaultValue(value = "true")]
		[MUXPropertyChangedCallback(enable = true)]
		public extern bool ShowAsMonochrome
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyDefaultValue(value = "true")]
			[MUXPropertyChangedCallback(enable = true)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallback(enable = true)]
			[MUXPropertyDefaultValue(value = "true")]
			[param: In]
			set;
		}

		public static extern DependencyProperty ShowAsMonochromeProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		public static extern DependencyProperty UriSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
