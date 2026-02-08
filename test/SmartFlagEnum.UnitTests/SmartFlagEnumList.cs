using System;
using System.Collections.Generic;
using System.Text;
using MartiX.SmartEnum.UnitTests;
using FluentAssertions;
using Xunit;

namespace MartiX.SmartFlagEnum.UnitTests
{
    public class SmartFlagEnumList
    {
        [Fact]
        public void ReturnsAllDefinedSmartEnums()
        {
            var result = SmartFlagTestEnum.List;

            result.Should().BeEquivalentTo(new[] {
                SmartFlagTestEnum.Zero, 
                SmartFlagTestEnum.One,
                SmartFlagTestEnum.Two,
                SmartFlagTestEnum.Three,
                SmartFlagTestEnum.Four,
                SmartFlagTestEnum.Five, 
            });
        }
    }
}
