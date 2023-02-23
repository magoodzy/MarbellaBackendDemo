using MarbellaMS.IRepositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MarbellaMS.Controllers
{

    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class FileUtilityController : ControllerBase
    {
        IFilesRepository _IFilesRepository;

        public FileUtilityController(IFilesRepository IFilesRepository)
        {
            _IFilesRepository = IFilesRepository;
        }

        [HttpPost("UploadFiles")]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            var file = Request.Form.Files;
            var uploadResponse = await _IFilesRepository.UploadFiles(file.ToList());
            if (uploadResponse.ErrorMessage != "")
                return BadRequest(new { error = uploadResponse.ErrorMessage });
            return Ok(uploadResponse);
        }



        //[Route("DownloadFile")]
        //[HttpGet]
        //public async Task<IActionResult> DownloadFile(int id)
        //{
        //    var stream =  _IFilesRepository.DownloadFile(id);
        //    if (stream == null)
        //        return NotFound();
        //    return new FileContentResult(stream, "application/octet-stream");
        //}

        [Route("DownloadFiles")]
        [HttpGet]
        public async Task<IActionResult> DownloadFile(int Id)
        {
            var files = _IFilesRepository.DownloadFile(Id);
            return Ok(files.ToList());
        }



    }
}