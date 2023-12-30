using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.CustomAttributes
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	[WebHostHidden]
	[Version(1u)]
	public sealed class MUXPropertyNeedsDependencyPropertyFieldAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		public extern MUXPropertyNeedsDependencyPropertyFieldAttribute();
	}
}
