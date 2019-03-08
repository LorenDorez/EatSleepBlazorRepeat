***
The Setup Instructions I Performed
***

1. Add Nuget Package `Microsoft.AspNetCore.Components.Server`

2. Add `services.AddRazorComponents();` to the `Startup.cs` in the `ConfigureServices` at the end.

3. Add `routes.MapComponentHub<RCLib.Shared.Components.App>("app")` to the `Startup.cs` in the `Configure` at the end of the `UseRouting()` section.
   - For each additional componnent you will need to add `.AddComponent<RCLib.Shared.Components.Counter> ("counter")`

4. Add a fake base tag `<base href="rc/fake" />` to the `head` section in `_Layout.cshtml` page under `Views\Shared`
   - This is a fake path to avoid the hijacking of all links
 
5. Add an `app` tag to the `_Layout.cshtml` page under `Views\Shared`
   - I did mine above the `@RenderBody()`

6. Now Add the SignalR JS file to the `_Layout.cshtml` page under `Views\Shared`
   - This file has to be overridden currently to fix relative Urls. You can find this in my `RCLib.Shared` project.
```HTML
<script src="~/js/components.server.js"></script>
```


