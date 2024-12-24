namespace PasswordProg.Tests
{
    public interface IStringExtensionsTests
    {
        void CountCapitalLetters_AllCapitalLetters_ReturnsCorrectCount();
        void CountCapitalLetters_EmptyString_ReturnsZero();
        void CountCapitalLetters_MixedCaseString_ReturnsCorrectCount();
        void CountCapitalLetters_NoCapitalLetters_ReturnsZero();
        void CountCapitalLetters_StringWithNumbersAndSymbols_ReturnsCorrectCount();
    }
}