using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfBlog.Frame;

namespace SelfBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ImageController : Controller
    {
        private readonly IHostingEnvironment _hostingEnv;
        public ImageController(IHostingEnvironment env)
        {
            _hostingEnv = env;
        }
        //参数名必须为imgFile和dir，否则kindeditor不会自动绑定
        public IActionResult ImageUpLoad(IList<IFormFile> imgFile, string dir)
        {
            PicUploadResponse rspJson = new PicUploadResponse() { error = 0, url = "/upload/" };
            long size = 0;
            string tempName = "";
            foreach (var file in imgFile)
            {
                var fileName = ContentDispositionHeaderValue
                    .Parse(file.ContentDisposition)
                    .FileName
                    .Trim('"');
                //string imageExt;
                //CommonHelper.GetImageFormat(filename, out imageExt);
                var ext = fileName.Substring(fileName.LastIndexOf("."), fileName.Length - fileName.LastIndexOf("."));
                var uniqueName = System.Guid.NewGuid().ToString() + ext;
                tempName = uniqueName;
                var directory = _hostingEnv.WebRootPath + $@"\upload\";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
                fileName = directory + uniqueName;
                size += file.Length;
                using (FileStream fs = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            rspJson.error = 0;
            rspJson.url = $@"../../upload/" + tempName;
            return Json(rspJson);
        }
    }
    public class PicUploadResponse
    {
        public int error { get; set; }
        public string url { get; set; }
    }
}