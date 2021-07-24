using Mutants.Validations;
using NUnit.Framework;

namespace Mutants.Tests.Validations
{
    [TestFixture]
    public class MutantValidationsTests
    {
        [Test]
        [TestCase(new string[] { "ATGCAA", "CTGTCA", "TTATGT", "AGAACT", "CCTTGC", "TCACT" }, false)]
        [TestCase(new string[] { "ATGCAA", "CTGTCA", "TTATGT", "AGAACT", "CCTTGC", "TCACTC" }, true)]
        public void IsDNAOrderNxNValidation_WhenCalled_ReturnsCorrectBool(string [] dna, bool expectedResult)
        {
            var result = MutantValidations.IsDNAOrderNxNValidation(dna);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new string[] { "ATGCAA", "CTGTCA", "TTATGT", "AGJACT", "CCTTGC", "TCACTC" }, false)]
        [TestCase(new string[] { "ATGCAA", "CTGTCA", "TTATGT", "AGjACT", "CCTTGC", "TCACTC" }, false)]
        [TestCase(new string[] { "ATGCAA", "CTGTCA", "TTATGT", "AGAACT", "CCTTGC", "TCACTC" }, true)]
        public void DNAHasOnlyValidCharacters_WhenCalled_ReturnsCorrectBool(string[] dna, bool expectedResult)
        {
            var result = MutantValidations.DNAHasOnlyValidCharacters(dna);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new string[] { "ATG", "CTG", "TTA" }, false)]
        [TestCase(new string[] { "ATGCAA", "CTGTCA", "TTATGT", "AGAACT", "CCTTGC", "TCACTC" }, true)]
        public void IsGreaterThanFour_WhenCalled_ReturnsCorrectBool(string[] dna, bool expectedResult)
        {
            var result = MutantValidations.IsGreaterThanFour(dna);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
