using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[WebHostHidden]
	[ExclusiveTo(typeof(AnimatedIcon))]
	[Windows.Foundation.Metadata.Guid(941135528u, 61087, 22563, 171, 241, 181, 150, 173, 204, 119, 209)]
	internal interface IAnimatedIconStatics
	{
		[MUXPropertyChangedCallbackMethodName(value = "OnAnimatedIconStatePropertyChanged")]
		DependencyProperty StateProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[MUXPropertyChangedCallbackMethodName(value = "OnAnimatedIconStatePropertyChanged")]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetState([In] DependencyObject @object, [In] string value);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetState([In] DependencyObject @object);

		DependencyProperty SourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty FallbackIconSourceProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}

		DependencyProperty MirroredWhenRightToLeftProperty
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
