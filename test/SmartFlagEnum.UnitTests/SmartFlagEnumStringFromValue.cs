using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MartiX.SmartEnum;
using MartiX.SmartEnum.Exceptions;
using MartiX.SmartEnum.UnitTests;
using FluentAssertions;
using Xunit;

namespace MartiX.SmartFlagEnum.UnitTests
{
    public class SmartFlagEnumStringFromValue
    {

        [Fact]
        public void ThrowsGivenNonMatchingValue()
        {
            var value = string.Empty;

            Action action = () => SmartFlagTestStringEnum.FromValue(value);

            action.Should()
                .ThrowExactly<InvalidFlagEnumValueParseException>()
                .WithMessage($"The value: {value.ToString()} input to {nameof(SmartFlagTestStringEnum)} could not be parsed into an integer value.");
        }

        [Fact]
        public void ReturnsDefaultEnumGivenNonMatchingValue()
        {
            var value = string.Empty;
            var defaultEnumValue = new List<SmartFlagTestStringEnum>{SmartFlagTestStringEnum.One, SmartFlagTestStringEnum.Two};

            var result = SmartFlagTestStringEnum.FromValue(value, defaultEnumValue);

            result.Should().BeSameAs(defaultEnumValue);
        }
    }
}
