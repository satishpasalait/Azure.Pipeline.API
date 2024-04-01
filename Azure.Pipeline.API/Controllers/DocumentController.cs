using Azure.Pipeline.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Azure.Pipeline.API.Controllers
{
    [ApiController]
    [Route("api/documents")]

    public class DocumentController : ControllerBase
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentController(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetDocumentsAsync()
        {
            try
            {
                return Ok(_documentRepository.GetDocuments());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
