using ExcelExtractor.Manager.Interface;
using ExcelExtractor.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExcelExtractor.Controllers
{
    public class ExtractorController : Controller
    {
        private readonly IExtractorService _extractorService;

        public ExtractorController(IExtractorService extractorService)
        {
            _extractorService = extractorService;
        }

        [HttpGet]
        public IActionResult Home()
        {
			try
			{
				return View();
			}
			catch (Exception)
			{
				throw;
			}
        }

        [HttpPost]
        public async Task<IActionResult> Home(List<ExcelModel> model)
        {
            try
            {
                await _extractorService.SaveExcel(model);

                return View();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
