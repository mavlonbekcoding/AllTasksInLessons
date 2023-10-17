using Raven.Database.FileSystem.Bundles.Encryption.Plugin;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class FileEncryption
{
    FileEncryption fileEncryption = new FileEncryption();
    async Task<await> FileEncryption.EncryptFileAsync("D:\NT Level2\AllTasksInLessons\TestFile\Test.txt", "D:\NT Level2\AllTasksInLessons\TestFile\ResultText.txt", "1514");

    public async Task EncryptFileAsync(string filePath, string key)
    {
        // Create a new instance of the AesCryptoServiceProvider class
        using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
        {
            // Generate a key and initialization vector (IV) from the input key
            aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(key));
            aes.IV = new byte[16]; // The IV is always 16 bytes for AES

            // Create a new file stream to write the encrypted data to the file
            await using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                // Create a new crypto stream to perform the encryption
                await using (CryptoStream cs = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    // Write the encrypted data to the crypto stream
                    await cs.WriteAsync(Encoding.UTF8.GetBytes("This is some text to encrypt"));
                }
            }
        }
    }
}
