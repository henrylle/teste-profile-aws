using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Amazon.S3;
using Amazon.S3.Model;

namespace OregonEAD2.Core.Integration.Concrete
{
    public class AmazonS3Integration
    {
        private readonly IAmazonS3 _amazoS3Client;
        private readonly string _ambiente;        

        public AmazonS3Integration(IAmazonS3 amazonS3ClientParam)
        {
            _amazoS3Client = amazonS3ClientParam;            
        }
        
        public async void CopiarArquivo(string caminhoArquivo, string nomeBucket)
        {
            CopyObjectRequest request = new CopyObjectRequest
            {
                SourceBucket = nomeBucket,
                SourceKey = caminhoArquivo,
                DestinationKey = caminhoArquivo,
                DestinationBucket = "conteudo-oregon",                
            };
            await _amazoS3Client.CopyObjectAsync(request);            
        }        
    }
}