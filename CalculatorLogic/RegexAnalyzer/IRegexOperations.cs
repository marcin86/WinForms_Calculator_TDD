namespace CalculatorLogic.RegexAnalyzer
{
    public interface IRegexOperations
    {
        bool IsLhsOperantPresent(string source, string pattern = @"^[+-]?([0-9]*[.]?[0-9]{1,})$");
        bool AreBothOperantsPresent(string source, string pattern = @"^([+-]?([0-9]*[.])?[0-9]+) [+-\/*] ([+-]?([0-9]*[.])?[0-9]+)$");
        bool IsTheLastSymbolAnOperationSymbol(string source, string pattern);

        float TakeLhsOperantValue(string source, string pattern);
        float TakeLastOperantValue(string source, string pattern = @"^[+-]?([0-9]*[.]?[0-9]{1,}) [+-\/*] [+-]?([0-9]*[.]?[0-9]{1,})+$");
    }
}
