﻿using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace LightX.Properties
{
	// Token: 0x02000009 RID: 9
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005A2C File Offset: 0x00003C2C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000045 RID: 69
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
