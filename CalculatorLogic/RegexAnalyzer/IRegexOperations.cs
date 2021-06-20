namespace CalculatorLogic.RegexAnalyzer
{
    public interface IRegexOperations
    {
        bool IsLhsOperantPresent(string source, string pattern);
        bool AreBothOperantsPresent(string source, string pattern);
        bool IsTheLastSymbolAnOperationSymbol(string source, string pattern);

        float TakeLhsOperantValue(string source, string pattern);
        float TakeLastOperantValue(string source, string pattern);
    }
}
