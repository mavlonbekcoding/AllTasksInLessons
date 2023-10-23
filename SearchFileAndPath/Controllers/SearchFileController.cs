using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchFileAndPath.Service.Interfaces;

namespace SearchFileAndPath.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchFileController : ControllerBase
    {
        private readonly ISearchFileLogicService _searchFileLogicService;

        public SearchFileController(ISearchFileLogicService searchFileLogicService)
        {
            _searchFileLogicService = searchFileLogicService;
        }
        [HttpGet("filePath")]
        public async ValueTask<IActionResult> SearchFile(string path)
        {
            var result = _searchFileLogicService.GetFilePath("D:\3-kurs",path);
            return Ok(result);
        }

    }
}
