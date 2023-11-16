using FiorelloBackend.Services.Interfaces;
using FiorelloBackend.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloBackend.VIewComponenets
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ILayoutIService _layoutIService;

        public HeaderViewComponent(ILayoutIService layoutIService)
        {
            _layoutIService=layoutIService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            HeaderVM model = _layoutIService.GetHeaderDatas();
            return await Task.FromResult(View(model));
        }
    }
}
