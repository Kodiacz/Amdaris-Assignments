using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace StreamsAssignment
{
    public class TxtStream
    {
        public static void WriteOnTxtFile()
        {
            string input = Console.ReadLine();

            if (!input.Contains(".txt"))
            {
                input += ".txt";
            }

            StreamWriter writer = new StreamWriter($@"C:\Simeon\Programming\Amdaris\Amdaris-Assignemnts-Git-Repo\Streams\{input}");

            for (int i = 1; i <= 5; i++)
            {
                string text = $"Line {i}";
                writer.WriteLine(text);
            }

            writer.Close();
        }

        public static void ReadFromTxtFile()
        {
            StreamReader reader = StreamReader.Null;

            try
            {
                reader = new StreamReader($@"C:\Simeon\Programming\Amdaris\Amdaris-Assignemnts-Git-Repo\Streams\test.txt");

                for (var (line, lineNumber) = (reader.ReadLine(), 1); line != null; line = reader.ReadLine(), lineNumber++)
                {
                    Console.WriteLine($"{lineNumber}: {line}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public static void Compress()
        {
            using Stream originalFile = File.Open($@"C:\Simeon\Programming\Amdaris\Amdaris-Assignemnts-Git-Repo\Streams\test.txt", FileMode.Open);
            using Stream compressedFile = File.Create($@"C:\Simeon\Programming\Amdaris\Amdaris-Assignemnts-Git-Repo\Streams\compressedFile.gz");

            using GZipStream gZipStream = new GZipStream(compressedFile, CompressionMode.Compress);

            originalFile.CopyTo(gZipStream);

            //originalFile.Close();
            //compressedFile.Close();
            //gZipStream.Close();
        }

        public static void Encrpyt()
        {
            byte[] encrypted;

            string text = "Some random text for encrypting";

            byte[] key;
            byte[] iv;

            using (Aes aes = Aes.Create())
            {
                key = aes.Key;
                iv = aes.IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(key, iv);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(text);
                        }

                        encrypted = memoryStream.ToArray();
                    }
                }
            }
        }

    }
}
