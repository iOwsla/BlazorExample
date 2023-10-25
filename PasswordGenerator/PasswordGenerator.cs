using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorApp
{
    public class PasswordGenerator
    {
        private readonly Random _random;
        private readonly StringBuilder _passwordBuilder;
        private readonly StringBuilder _charSetBuilder;

        public PasswordGenerator()
        {
            _random = new Random();
            _passwordBuilder = new StringBuilder();
            _charSetBuilder = new StringBuilder();

        }
        public int Length { get; set; }
        public bool IncludeLowercase { get; set; } = true;
        public bool IncludeUppercase { get; set; } = true;
        public bool IncludeNumbers { get; set; } = true;
        public bool IncludeSpecial { get; set; } = true;

        private readonly string _lowercase = "abcdefghijklmnopqrstuvwxyz";
        private readonly string _uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _numbers = "0123456789";
        private readonly string _specials = "!@#$%^&*()_+";

        public string Generate()
        {
            _passwordBuilder.Clear();
            string newChars = SetCharBuilder();

            for (int i = 0; i < Length; i++)
            {
                _passwordBuilder.Append(newChars[_random.Next(0, newChars.Length)]);
            }

            return _passwordBuilder.ToString();
        }

        private string SetCharBuilder()
        {
            if (IncludeLowercase) _charSetBuilder.Append(_lowercase);
            if (IncludeUppercase) _charSetBuilder.Append(_uppercase);
            if (IncludeNumbers) _charSetBuilder.Append(_numbers);
            if (IncludeSpecial) _charSetBuilder.Append(_specials);
            
            return _charSetBuilder.ToString();
        }

    }
}
