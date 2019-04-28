using System.IO;
//Install-Package MarkerMetro.Unity.Ionic.Zlib
namespace webapi.Helpers
{
    public class CompressionHelper
    {
        public static byte[] GZipByte(byte[] str)
        {
            if (str == null) return null;
        
            using (var output = new MemoryStream())
            {
                using (
                    var compressor = new Ionic.Zlib.GZipStream(
                    output, Ionic.Zlib.CompressionMode.Compress,
                    Ionic.Zlib.CompressionLevel.BestSpeed))
                {
                    compressor.Write(str, 0, str.Length);
                }
                return output.ToArray();
            }
        }
    }
}