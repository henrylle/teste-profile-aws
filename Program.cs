using System;
using System.Threading.Tasks;
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
            TestAsyncAwaitMethods();
        }

        public static void TestAsyncAwaitMethods()
        {
            var credentials = new InstanceProfileAWSCredentials();
            //var credentials = new StoredProfileAWSCredentials("elore");
            var amazonS3Client = new AmazonS3Client(credentials, RegionEndpoint.USEast1);
            var amazonS3Integration = new AmazonS3Integration(amazonS3Client);
            Console.WriteLine("OK");
            Task.Run(() => amazonS3Integration.CopiarArquivo("video_profile.mp4", "conteudo-oregon-temp"));
            Console.ReadKey();
        }

    }
}
