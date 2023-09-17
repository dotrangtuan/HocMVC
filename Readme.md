## Controller 
- Là một lớp được kế thừa từ lớp Controller
- Acction trong controller là một phương thức public (không được là static)
- Action trả bất kiểu dữ liệu gì, thường là IActionResult
- Các dịch vụ được inject vào các controller qua hàm tạo để sử dụng 

## View 
- là các file .cshtml
- View cho Action lưu tại: Views/Controller/ActionName.cshtml


-- config thêm đường dẫn cho view trường 
// {0} actions
// {1} controller
// {2} areas
options => {
    options.ViewLocationFormats.Add("/MyViews/{1}/{0}" + RazorViewEngine.ViewExtension);
}

## Truyền dữ liệu sang View
- Model 
- ViewData
- ViewBag
- TempData (sẽ lưu ở section storage nên các trang có thể truy cập)
