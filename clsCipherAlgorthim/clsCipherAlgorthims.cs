using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace clsCipherAlgorthim
{

        public class clsCipherAlgorthims
        {
            public string Enc_Qaeser(string PlainText)
            {
                int x;
                string Ciphertext = string.Empty;
                for (int i = 0; i < PlainText.Length; i++)
                {
                    if (char.IsUpper(PlainText[i]))
                    {
                        x = PlainText[i] - 65;
                        x += 3;
                        x %= 26;
                        Ciphertext += (char)(x += 65);
                    }
                    else if (char.IsLower(PlainText[i]))
                    {
                        x = PlainText[i] - 97;
                        x += 3;
                        x %= 26;
                        Ciphertext += (char)(x += 97);
                    }
                    else
                    {
                        Ciphertext += PlainText[i];
                    }
                }
                return Ciphertext;
            }
            public string Dec_Qaeser(string Ciphertext)
            {
                int x;
                string PlainText = string.Empty;
                for (int i = 0; i < Ciphertext.Length; i++)
                {
                    if (Ciphertext[i] >= 'A' && Ciphertext[i] <= 'Z')
                    {
                        x = Ciphertext[i] - 65;
                        x -= 3;
                        x = (x < 0) ? 26 - Math.Abs(x) : x;
                        PlainText += (char)(x += 65);
                    }
                    else if (Ciphertext[i] >= 'a' && Ciphertext[i] <= 'z')
                    {
                        x = Ciphertext[i] - 97;
                        x -= 3;
                        x = (x < 0) ? 26 - Math.Abs(x) : x;
                        PlainText += (char)(x += 97);

                    }
                    else
                    {
                        PlainText += Ciphertext[i];
                    }
                }
                return PlainText;
            }

            public string Root13Cipher(string PlainText) // هي نفس الكود لتشفير وفك التشفير
            {
                int value;
                string CipherText = string.Empty;
                for (int i = 0; i < PlainText.Length; i++)
                {
                    if ((int)PlainText[i] >= 'A' && PlainText[i] <= 'Z')
                    {
                        value = (int)PlainText[i] - 65;
                        value += 13;
                        value %= 26;
                        CipherText += (char)(value += 65);
                    }
                    else if (PlainText[i] >= 'a' && PlainText[i] <= 'z')
                    {
                        CipherText += (char)(((((int)PlainText[i] - 97) + 13) % 26) + 97);
                    }
                    else
                    {
                        CipherText += PlainText[i];
                    }
                }
                return CipherText;
            }

            public string AtbashCipher(string PlainText) // هي نفس الكود لتشفير وفك التشفير
            {
                string CipherText = string.Empty;
                char[] S_Letters = new char[26];
                char[] C_Letters = new char[26];

                char Ch_C = 'Z';
                char Ch_S = 'z';

                for (int i = 0; i < 26; i++)
                {
                    S_Letters[i] = Ch_S--;
                    C_Letters[i] = Ch_C--;
                }

                for (int i = 0; i < PlainText.Length; i++)
                {
                    if (char.IsUpper(PlainText[i]))
                    {
                        CipherText += C_Letters[(int)PlainText[i] - 65];
                    }
                    else if (char.IsLower(PlainText[i]))
                    {
                        CipherText += S_Letters[(int)PlainText[i] - 97];
                    }
                    else if (char.IsDigit(PlainText[i]))
                    {
                        CipherText += PlainText[i];
                    }
                }
                return CipherText;
            }

            public string Enc_SimpleVengereCipher(string PlainText, string Key)
            {
                string CipherText = string.Empty;
                int Value, count = Key.Length;

                for (int i = 0; i < PlainText.Length; i++)
                {
                    if (char.IsUpper(PlainText[i]))
                    {
                        Value = ((int)PlainText[i] - 65) + ((int)Key[i % count] - 65);
                        Value %= 26;
                        CipherText += (char)(Value + 65);
                    }
                    else if (char.IsLower(PlainText[i]))
                    {
                        Value = ((int)PlainText[i] - 97) + ((int)Key[i % count] - 97);
                        Value %= 26;
                        CipherText += (char)(Value + 97);
                    }
                    else
                    {
                        CipherText += PlainText[i];
                    }
                }
                return CipherText;
            }

            public string Dec_SimpleVengereCipher(string CipherText, string Key)
            {
                string PlainText = string.Empty;
                int Value, count = Key.Length;

                for (int i = 0; i < CipherText.Length; i++)
                {
                    if (char.IsUpper(CipherText[i]))
                    {
                        Value = ((int)CipherText[i] - 65) - ((int)Key[i % count] - 65);
                        Value = (Value < 0) ? 26 - Math.Abs(Value) : Value;
                        PlainText += (char)(Value + 65);
                    }
                    else if (char.IsLower(CipherText[i]))
                    {
                        Value = ((int)CipherText[i] - 97) - ((int)Key[i % count] - 97);
                        Value = (Value < 0) ? 26 - Math.Abs(Value) : Value;
                        PlainText += (char)(Value + 97);
                    }
                    else
                    {
                        PlainText += CipherText[i];
                    }
                }
                return PlainText;
            }

            public int GCD(int m, int n)
            {
                if (n == 0)
                    return m;
                else
                    return GCD(n, m % n);
            }

            public int Inverse(int m)
            {
                for (int i = 1; i < 26; i++)
                {
                    if ((m * i) % 26 == 1)
                    {
                        return i;
                    }
                }
                return -1;
            }


            public string Enc_Affine(string PlainText, int Key, int m)
            {
                if (GCD(m, 26) != 1)
                {
                    Console.WriteLine("no cipher becauce gcd !=1");
                    return "";
                }
                string CipherText = "";
                int value;
                for (int i = 0; i < PlainText.Length; i++)
                {

                    if (char.IsUpper(PlainText[i]))
                    {
                        value = PlainText[i] - 'A';
                        value = (m * value + Key) % 26;
                        CipherText += (char)(value + 'A');
                    }
                    else if (char.IsLower(PlainText[i]))
                    {
                        value = PlainText[i] - 'a';
                        value = (m * value + Key) % 26;
                        CipherText += (char)(value + 'a');
                    }
                    else
                    {
                        CipherText += PlainText[i];
                    }
                }
                return CipherText;
            }


            public string Dec_Affine(string CipherText, int Key, int m)
            {
                if (GCD(m, 26) != 1)
                {
                    Console.WriteLine("no cipher becauce gcd !=1");
                    return "";
                }

                string PlainText = "";
                int inverse = Inverse(m);
                int x;

                for (int i = 0; i < CipherText.Length; i++)
                {
                    if (char.IsUpper(CipherText[i]))
                    {
                        x = CipherText[i] - 'A';
                        x = inverse * (x - Key);
                        x %= 26;

                        if (x < 0)
                            x += 26;

                        PlainText += (char)(x + 'A');
                    }
                    else if (char.IsLower(CipherText[i]))
                    {
                        x = CipherText[i] - 'a';
                        x = inverse * (x - Key);
                        x %= 26;
                        if (x < 0)
                            x += 26;

                        PlainText += (char)(x + 'a');
                    }
                    else
                    {
                        PlainText += CipherText[i];
                    }
                }
                return PlainText;
            }

            byte[] key = Encoding.UTF8.GetBytes("1234567890123456");
            byte[] IV = Encoding.UTF8.GetBytes("1234567890123456");
            public string Enc_AES(string PlainText)
            {
                byte[] data;
                using (Aes aes = Aes.Create())
                {
                    //aes.GenerateIV();
                    //IV = aes.IV;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(
                            ms,
                            aes.CreateEncryptor(key, IV),
                            CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(PlainText);
                            }
                            data = ms.ToArray();
                        }
                    }
                }
                return Convert.ToBase64String(data);
            }

            public string Dec_AES(string CipherText)
            {
                byte[] data = Convert.FromBase64String(CipherText);
                string PlainText;
                using (Aes aes = Aes.Create())
                {
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        using (CryptoStream cs = new CryptoStream(
                            ms,
                            aes.CreateDecryptor(key, IV),
                            CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                PlainText = sr.ReadToEnd();
                            }
                        }
                    }
                }
                return PlainText;
            }

            public string HSA256_Hash(string PlinText)
            {
                byte[] data = Encoding.UTF8.GetBytes(PlinText);
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] hash = sha256Hash.ComputeHash(data);
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in hash)
                    {
                        builder.Append(b.ToString("x2")); // Convert to hexadecimal string
                    }
                    return builder.ToString();
                }
            }

            public string MD5_Hash(string PlainText)
            {
                byte[] data = Encoding.UTF8.GetBytes(PlainText);
                using (MD5 mds = MD5.Create())
                {
                    byte[] hash = mds.ComputeHash(data);
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in hash)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }

            RSAParameters key1, key2;
            public string RSA_Enc(string plintext)
            {
                byte[] data = Encoding.UTF8.GetBytes(plintext);
                byte[] ciphertext;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    key1 = rsa.ExportParameters(false);
                    key2 = rsa.ExportParameters(true);
                    rsa.ImportParameters(key1);
                    ciphertext = rsa.Encrypt(data, true);
                    return Convert.ToBase64String(ciphertext);
                }
            }

            public string RSA_Dec(string ciphertext)
            {
                byte[] data = Convert.FromBase64String(ciphertext);
                byte[] plaintext;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(key2);
                    plaintext = rsa.Decrypt(data, true);
                }
                return Encoding.UTF8.GetString(plaintext);
            }


        }
    }
