using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	[WebHostHidden]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	[Version(1u)]
	public sealed class MUXPropertyValidationCallbackAttribute : Attribute
	{
		public string value;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern MUXPropertyValidationCallbackAttribute();
	}
}
