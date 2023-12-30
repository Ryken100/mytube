using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[ContractVersion(typeof(XamlContract), 65536u)]
	[Flags]
	[WebHostHidden]
	public enum ElementRealizationOptions : uint
	{
		None = 0u,
		ForceCreate = 1u,
		SuppressAutoRecycle = 2u
	}
}
