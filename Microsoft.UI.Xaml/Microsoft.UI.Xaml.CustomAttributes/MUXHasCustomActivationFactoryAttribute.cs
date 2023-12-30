using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[Version(1u)]
	[WebHostHidden]
	public sealed class MUXHasCustomActivationFactoryAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern MUXHasCustomActivationFactoryAttribute();
	}
}
