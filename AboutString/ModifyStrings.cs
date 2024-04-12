using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace AboutString
{
    public class ModifyStrings
    {
        public static string SplitParagraph(string paragraph, char separator)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            foreach (string sentence in paragraph.Split(separator))
            // foreach (string sentence in paragraph.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)) // .net core does not have those options, I need to use regex to acomlish similar
            {
                sb.Append($"{counter++}: { sentence}.");
            }

            return sb.ToString();
        }

        public static string SplitDataWithMultipleSeparators(string data, char[] separators)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            foreach (string item in data.Split(separators))
            {
                sb.Append($"{counter++}: {item}");
            }

            return sb.ToString();
        }

        public static bool SplitIPs(string ip)
        {
            const string ipPattern = "^([0-9]{1,3})\\.([0-9]{1,3})\\.([0-9]{1,3})\\.([0-9]{1,3})$"; // naive pattern

            bool isIp = Regex.IsMatch(ip, ipPattern);
            return isIp;
        }

        /// <summary>
        /// experiments with substring function
        /// </summary>
        /// <param name="perfumeData"></param>
        public static Perfume ParsePerfumeData(string[] perfumeData)
        {
            Perfume perfume = new Perfume();

            foreach (string data in perfumeData)
            {
                int colon = data.IndexOf(':');
                int start = colon + 2;
                // int end = data[^1] == '.' ? data.Length - 1 : data.Length;
                int end = data.EndsWith(".") ? data.Length - 1 : data.Length;

                if (data.Length > start)
                {
                    string propertyName = data.Substring(0, colon);
                    string propertyValue = data.Substring(start, end - start);
                    if (propertyName == "Brand")
                    {
                        perfume.Brand = propertyValue;
                    }
                    else if (propertyName == "Perfume Name")
                    {
                        perfume.Name = propertyValue;
                    }
                    else if (propertyName == "Volume (in ml)")
                    {
                        if (int.TryParse(propertyValue, out int volume))
                        {
                            perfume.Volume = volume;
                        }
                    }
                    else if (propertyName == "Launched in")
                    {
                        if (int.TryParse(propertyValue, out int year))
                        {
                            perfume.LaunchYear = year;
                        }
                    }
                    else if (propertyName == "Nose")
                    {
                        perfume.Nose = propertyValue;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return perfume;
        }

        public class Perfume
        {
            public string Brand { get; set; }
            public string Name { get; set; }
            public int Volume { get; set; }
            public int LaunchYear { get; set; }
            public string Nose { get; set; }
        }

        public static string ChangeCaseToUpperInvariant(string input)
        {
            return input.ToUpperInvariant();
        }

        public static string ChangeCaseToLowerInvariant(string input)
        {
            return input.ToLowerInvariant();
        }

        public static char ChangeCharCaseToLowerInvariant(char character)
        {
            return char.ToLowerInvariant(character);
        }

        public static string ChangeJsonCase(string perfumeJsonRepresentation)
        {
            TextInfo textInfo = new CultureInfo("en-GB", false).TextInfo;
            string intermediateName = textInfo.ToTitleCase(perfumeJsonRepresentation);
            string formattedRepresentation = intermediateName.Replace("_", " ");
            return formattedRepresentation;
        }

        public static string FormatWhitespaceTrim(string input)
        {
            input = input.Trim();
            return $"{input}END";
        }

        public static string FormatWhitespaceTrimStart(string input)
        {
            input = input.TrimStart();
            return $"{input}END";
        }

        public static string FormatWhitespaceTrimEnd(string input)
        {
            input = input.TrimEnd();
            return $"{input}END";
        }

        public static string FormatCodeComment(string comment)
        {
            char[] charsTotrim = new[] { '/', ' ' };
            string trimmedComment = comment.Trim(charsTotrim);
            return trimmedComment;
        }

        public static string FormatPerfumeBrandsPadLeft(string[] perfumeBrands, int totalWidth = 15)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string brand in perfumeBrands)
            {
                sb.Append(brand.PadLeft(totalWidth, ' '));
            }
            return sb.ToString();
        }

        public static string StandardizeNamesList(string[] namesList)
        {
            StringBuilder sb = new StringBuilder();

            // standartize the names list
            const string regexPattern = "^[0-9]{1,2}\\. ?";
            foreach (string name in namesList)
            {
                // pattern based string manipulation
                sb.Append(Regex.Replace(name, regexPattern, string.Empty));
                sb.Append(";");
            }

            return sb.ToString();
        }
    }
}
