using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarlingKirk.Models
{
    public class Video
    {
        private string _fileExtension;

        public Video(string fileExtension)
        {
            _fileExtension = fileExtension;
        }
        public async Task StreamVideo(Stream stream, HttpContent content, TransportContext transport)
        {
            try
            {
                var buffer = new byte[65536];
                var filename = Path.Combine(String.Format("{0}{1}video.{2}", System.Web.HttpContext.Current.Server.MapPath("~"), Constants.FilePath, _fileExtension));
                using (var file = File.Open(filename, FileMode.Open, FileAccess.Read))
                {
                    var videoLength = (int)file.Length;
                    var placeInFile = 1;

                    while (videoLength > 0 && placeInFile > 0)
                    {
                        placeInFile = file.Read(buffer, 0, Math.Min(videoLength, buffer.Length));
                        await stream.WriteAsync(buffer, 0, placeInFile);
                        videoLength -= placeInFile;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.InnerException);
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
