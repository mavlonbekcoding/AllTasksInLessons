namespace TestShifr;

using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class FileEncryption
{
    public async Task EncryptFileAsync(string inputFilePath, string outputFilePath, string key)
    {
        // Create a new instance of the AesCryptoServiceProvider class
        using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
        {
            // Generate a key and initialization vector (IV) from the input key
            aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(key));
            aes.IV = new byte[16]; // The IV is always 16 bytes for AES

            // Create a new file stream to read the data from the input file
            await using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open))
            {
                // Create a new file stream to write the encrypted data to the output file
                await using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
                {
                    // Create a new crypto stream to perform the encryption
                    await using (CryptoStream cs = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        // Copy the data from the input file to the crypto stream, performing the encryption
                        await inputFileStream.CopyToAsync(cs);
                    }
                }
            }
        }
    }
}

