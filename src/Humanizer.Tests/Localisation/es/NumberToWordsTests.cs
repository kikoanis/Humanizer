﻿using Xunit;
using Xunit.Extensions;

namespace Humanizer.Tests.Localisation.es
{
    public class NumberToWordsTests : AmbientCulture
    {
        public NumberToWordsTests() : base("es-ES") { }

        [Theory]
        [InlineData(0, "cero")]
        [InlineData(1, "uno")]
        [InlineData(10, "diez")]
        [InlineData(11, "once")]
        [InlineData(122, "ciento veintidós")]
        [InlineData(3501, "tres mil quinientos uno")]
        [InlineData(100, "cien")]
        [InlineData(1000, "mil")]
        [InlineData(100000, "cien mil")]
        [InlineData(1000000, "millón")]
        [InlineData(10000000, "diez millones")]
        [InlineData(100000000, "cien millones")]
        [InlineData(1000000000, "mil millones")]
        [InlineData(111, "ciento once")]
        [InlineData(1111, "mil ciento once")]
        [InlineData(111111, "ciento once mil ciento once")]
        [InlineData(1111111, "millón ciento once mil ciento once")]
        [InlineData(11111111, "once millones ciento once mil ciento once")]
        [InlineData(111111111, "ciento once millones ciento once mil ciento once")]
        [InlineData(1111111111, "mil millones ciento once millones ciento once mil ciento once")]
        [InlineData(123, "ciento veintitrés")]
        [InlineData(1234, "mil doscientos treinta y cuatro")]
        [InlineData(12345, "doce mil trescientos cuarenta y cinco")]
        [InlineData(123456, "ciento veintitrés mil cuatrocientos cincuenta y seis")]
        [InlineData(1234567, "millón doscientos treinta y cuatro mil quinientos sesenta y siete")]
        [InlineData(12345678, "doce millones trescientos cuarenta y cinco mil seiscientos setenta y ocho")]
        [InlineData(123456789, "ciento veintitrés millones cuatrocientos cincuenta y seis mil setecientos ochenta y nueve")]
        [InlineData(1234567890, "mil millones doscientos treinta y cuatro millones quinientos sesenta y siete mil ochocientos noventa")]
        [InlineData(15, "quince")]
        [InlineData(16, "dieciséis")]
        [InlineData(20, "veinte")]
        [InlineData(22, "veintidós")]
        [InlineData(25, "veinticinco")]
        [InlineData(35, "treinta y cinco")]
        [InlineData(1999, "mil novecientos noventa y nueve")]
        [InlineData(2014, "dos mil catorce")]
        [InlineData(2048, "dos mil cuarenta y ocho")]
        public void ToWords(int number, string expected)
        {
            Assert.Equal(expected, number.ToWords());
        }

        [Theory]
        [InlineData(1, "primero", null)]
        [InlineData(2, "segundo", GrammaticalGender.Masculine)]
        [InlineData(2, "segunda", GrammaticalGender.Feminine)]
        [InlineData(2, "segundo", GrammaticalGender.Neuter)]
        [InlineData(11, "once", null)]
        public void ToOrdinalWords(int number, string words, GrammaticalGender gender)
        {
            Assert.Equal(words, number.ToOrdinalWords(gender));
        }
    }
}