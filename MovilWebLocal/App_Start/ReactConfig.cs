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
			  .SetLoadBabel(true)
			  .SetLoadReact(true)
			  //.SetReactAppBuildPath("~/wwwroot/dist");
			.AddScriptWithoutTransform("~/Scripts/dist/runtime.js")
  .AddScriptWithoutTransform("~/Scripts/dist/vendor.js")
  .AddScriptWithoutTransform("~/Scripts/dist/main.js");
			JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
			JsEngineSwitcher.Current.EngineFactories.AddV8();
		}
	}
}