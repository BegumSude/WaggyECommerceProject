using Microsoft.AspNetCore.Mvc;

namespace WaggyProject.ViewComponents.Default_Index
{
    public class DefaultSendMessageViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
