using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Debil.Vision.Properties
{
	// Token: 0x0200000F RID: 15
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00007BF0 File Offset: 0x00005DF0
		internal Resources()
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00007BF8 File Offset: 0x00005DF8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Debil.Vision.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00007C24 File Offset: 0x00005E24
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00007C2B File Offset: 0x00005E2B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00007C33 File Offset: 0x00005E33
		internal static Bitmap vision
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("vision", Resources.resourceCulture);
			}
		}

		// Token: 0x0400005B RID: 91
		private static ResourceManager resourceMan;

		// Token: 0x0400005C RID: 92
		private static CultureInfo resourceCulture;
	}
}
