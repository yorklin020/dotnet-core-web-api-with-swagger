# dotnet-core-web-api-with-swagger

1. 開啟 Visual Studio 2019。
2. 建立新的專案。
3. 搜尋範本: ASP.NET Core Web API → 下一步。
4. 專案名稱: (任意) ASP.NET Core Web API with Swagger → 下一步。
5. F5 執行。
6. 執行結果為產生之 JSON。
7. 開始加入 Swagger (文獻: https://docs.microsoft.com/zh-tw/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio)
8. 開啟 Nuget (工具 → Nuget 套件管理員 → 管理方案的 Nuget 套件)
	瀏覽並安裝以下三個元件:
	1. Swashbuckle.AspNetCore.Swagger
	2. Swashbuckle.AspNetCore.SwaggerGen
	3. Swashbuckle.AspNetCore.SwaggerUI
9.開啟 Startup.cs
	增加 using Microsoft.OpenApi.Models;
	
	ConfigureServices Method 中增加
		services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SwaggerDemoAPI", Version = "v1" });
            });
			
	Configure Method 中找到 if (env.IsDevelopment()) ，並增加
		app.UseSwagger();
		app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SwaggerDemoAPI v1"));
		在 app.UseDeveloperExceptionPage(); 下方。

10. 開啟 Properties → launchSettings.json
	將 launchUrl 修改成 swagger。
11. F5 執行
12. 進階參考 Github 原碼 (文獻: https://www.c-sharpcorner.com/blogs/net-core-api-with-swagger-documentation)
	分別增加
		Models → SampleModel
		Controllers → SampleController
