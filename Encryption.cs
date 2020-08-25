using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Debil.Vision
{
	// Token: 0x02000009 RID: 9
	internal class Encryption
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00003DE8 File Offset: 0x00001FE8
		public static string APIService(string value)
		{
			string password = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			byte[] key = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
			byte[] iv = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.EncryptString(value, key, iv);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003E48 File Offset: 0x00002048
		public static string EncryptService(string value)
		{
			string password = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			byte[] key = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
			byte[] iv = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			string str = Encryption.EncryptString(value, key, iv);
			int property = int.Parse(OnProgramStart.AID.Substring(0, 2));
			return str + Security.Obfuscate(property);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003EC4 File Offset: 0x000020C4
		public static string DecryptService(string value)
		{
			string password = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			byte[] key = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
			byte[] iv = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.DecryptString(value, key, iv);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003F24 File Offset: 0x00002124
		public static string EncryptString(string plainText, byte[] key, byte[] iv)
		{
			Aes encryptor = Aes.Create();
			encryptor.Mode = CipherMode.CBC;
			encryptor.Key = key;
			encryptor.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);
			byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);
			cryptoStream.Write(plainBytes, 0, plainBytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] cipherBytes = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003FA0 File Offset: 0x000021A0
		public static string DecryptString(string cipherText, byte[] key, byte[] iv)
		{
			Aes encryptor = Aes.Create();
			encryptor.Mode = CipherMode.CBC;
			encryptor.Key = key;
			encryptor.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);
			string plainText = string.Empty;
			try
			{
				byte[] cipherBytes = Convert.FromBase64String(cipherText);
				cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
				cryptoStream.FlushFinalBlock();
				byte[] plainBytes = memoryStream.ToArray();
				plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return plainText;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000403C File Offset: 0x0000223C
		public static string Decode(string text)
		{
			text = text.Replace('_', '/').Replace('-', '+');
			int num = text.Length % 4;
			if (num != 2)
			{
				if (num == 3)
				{
					text += "=";
				}
			}
			else
			{
				text += "==";
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(text));
		}
	}
}
