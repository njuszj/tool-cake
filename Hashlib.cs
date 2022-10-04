using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyToolBox
{
    public class Hashlib
    {
        public enum HashAlgoType
        {
            MD5,
            SHA1,
            SHA256,
        }
        public static String ByteArrayToHexDigest(Byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        public static HashAlgorithm SwitchHashService(HashAlgoType hashAlgo)
        {
            HashAlgorithm hashService = null;
            switch (hashAlgo)
            {
                case HashAlgoType.MD5:
                    hashService = new MD5CryptoServiceProvider();
                    break;
                case HashAlgoType.SHA1:
                    hashService = new SHA1CryptoServiceProvider();
                    break;
                case HashAlgoType.SHA256:
                    hashService = new SHA256CryptoServiceProvider();
                    break;
                default:
                    // TODO: 记录错误
                    break;
            }
            return hashService;
        }


        public static String GetStreamHexHash(String path, HashAlgoType hashAlgo)
        {
            using(FileStream fs = File.OpenRead(path))
            {
                HashAlgorithm hashService = SwitchHashService(hashAlgo);
                if (hashService != null)
                {
                    byte[] tmpHash = hashService.ComputeHash(fs);
                    return ByteArrayToHexDigest(tmpHash);
                }
            }
            return null;
        }

        public static String GetTextHexHash(String text, HashAlgoType hashAlgo)
        {
            byte[] tmpSource = Encoding.UTF8.GetBytes(text);
            HashAlgorithm hashService = SwitchHashService(hashAlgo);
            if(hashService != null)
            {
                byte[] tmpHash = hashService.ComputeHash(tmpSource);
                return ByteArrayToHexDigest(tmpHash);
            }
            return null;
        }
    }
}
