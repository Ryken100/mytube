using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.UI.Xaml.CustomAttributes;
using Windows.Foundation.Metadata;

namespace Microsoft.UI.Xaml.Controls
{
	[ComImport]
	[MUXPropertyNeedsDependencyPropertyField]
	[Windows.Foundation.Metadata.Guid(2643202642u, 22213, 22447, 154, 58, 8, 233, 185, 71, 229, 250)]
	[WebHostHidden]
	[ExclusiveTo(typeof(PipsPagerTemplateSettings))]
	[ContractVersion(typeof(XamlContract), 65536u)]
	internal interface IPipsPagerTemplateSettings
	{
		IList<int> PipsPagerItems
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			get;
		}
	}
}
