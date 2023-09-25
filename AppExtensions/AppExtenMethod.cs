using System.Net;

public static class AppExtenMethod {
    public static void AddStatusCodePage(this IApplicationBuilder app) {
        app.UseStatusCodePages(errorApp => {
        errorApp.Run(async context => {
        var response = context.Response;
        var code = response.StatusCode;
        var content = @$"<html lang='en'>
            <head>
                <meta charset='UTF-8'/>
                <title>{code}</title>
            </head>
            <body>
                <p style='color: red;'>{code} - {(HttpStatusCode) code}</p>
                <p> HEHE </p>
            </body>
        </html>";

        await context.Response.WriteAsync(content);
    });
});
    }
}