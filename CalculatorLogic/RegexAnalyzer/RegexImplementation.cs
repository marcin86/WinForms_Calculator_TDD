using System.Text.RegularExpressions;

namespace CalculatorLogic.RegexAnalyzer
{
    public class RegexImplementation : IRegexOperations
    {
        public bool IsLhsOperantPresent(string source, string pattern)
        {
            return CheckCommonFunctionality(source, pattern);
        }

        public bool AreBothOperantsPresent(string source, string pattern)
        {
            return CheckCommonFunctionality(source, pattern);
        }

        public bool IsTheLastSymbolAnOperationSymbol(string source, string pattern)
        {
            return CheckCommonFunctionality(source, pattern);
        }

        public float TakeLhsOperantValue(string source, string pattern)
        {
            float result = float.NaN;
            GroupCollection groups = TakeCommonFunctionality(source, pattern);
            bool parseResult = float.TryParse(groups[0].Value, out result);

            if (true == parseResult)
            {
                return result;
            }

            return float.NaN;
        }

        public float TakeLastOperantValue(string source, string pattern)
        {
            float result = float.NaN;

            GroupCollection groups = TakeCommonFunctionality(source, pattern);
            bool parseResult = float.TryParse(groups[2].Value, out result);

            if (true == parseResult)
            {
                return result;
            }
            else
            {
                return float.NaN;
            }
        }

        private bool CheckCommonFunctionality(string source, string pattern)
        {
            Match match = ExecuteRegexOnTheSource(source, pattern);

            if (match.Success)
            {
                return true;
            }

            return false;
        }

        private GroupCollection TakeCommonFunctionality(string source, string pattern)
        {
            Match match = ExecuteRegexOnTheSource(source, pattern);
            return match.Groups;
        }

        private Match ExecuteRegexOnTheSource(string source, string pattern)
        {
            Regex regex = new Regex(pattern);
            return regex.Match(source);
        }
    }
}
