using CarlingKirk.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace CarlingKirk.Controllers.api
{
    public class VideoStreamController : ApiController
    {
        // GET: api/VideoStream
        [HttpGet]
        [Route("api/Video/{fileExtension?}")]
        public HttpResponseMessage Get(string fileExtension = "mp4")
        {
            var video = new Video(fileExtension);
            var response = Request.CreateResponse();
            response.Content = new PushStreamContent(async (Stream outputStream, HttpContent content, TransportContext context) => { await video.StreamVideo(outputStream, content, context); }, new MediaTypeHeaderValue(String.Format("video/{0}", fileExtension)));
            return response;
        }
    }
}
