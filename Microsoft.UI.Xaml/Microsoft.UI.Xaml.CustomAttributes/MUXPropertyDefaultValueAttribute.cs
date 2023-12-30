using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	[Version(1u)]
	[WebHostHidden]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false)]
	public sealed class MUXPropertyDefaultValueAttribute : Attribute
	{
		public string value;

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern MUXPropertyDefaultValueAttribute();
	}
}
