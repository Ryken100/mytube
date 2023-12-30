using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	[Version(1u)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	[WebHostHidden]
	public sealed class MUXPropertyChangedCallbackMethodNameAttribute : Attribute
	{
		public string value;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern MUXPropertyChangedCallbackMethodNameAttribute();
	}
}
