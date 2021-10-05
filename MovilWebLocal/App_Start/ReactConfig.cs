using React;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MovilWebLocal.ReactConfig), "Configure")]

namespace MovilWebLocal
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			ReactSiteConfiguration.Configuration
			  .SetLoadBabel(false)
			  .SetLoadReact(false)
			  .SetReactAppBuildPath("~/dist");
			JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
			JsEngineSwitcher.Current.EngineFactories.AddV8();
		}
	}
}