using System;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using OregonEAD2.Core.Integration.Concrete;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var amazonS3Client = new AmazonS3Client(new InstanceProfileAWSCredentials(), RegionEndpoint.USEast1);
            var amazonS3Integration = new AmazonS3Integration(amazonS3Client);
            amazonS3Integration.CopiarArquivo("video_profile.mp4", "conteudo-oregon-temp");
            Console.WriteLine("Hello World!");
        }
    }
}
