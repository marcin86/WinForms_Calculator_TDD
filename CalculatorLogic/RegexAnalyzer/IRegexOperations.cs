namespace CalculatorLogic.RegexAnalyzer
{
    public interface IRegexOperations
    {
        bool IsLhsOperantPresent(string source);
        bool AreBothOperantsPresent(string source);
        bool IsTheLastSymbolAnOperationSymbol(string source);

        float TakeLhsOperantValue(string source);
        float TakeLastOperantValue(string source);
    }
}
