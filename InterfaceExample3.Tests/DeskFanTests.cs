using System;
using Xunit;
using DiveIntoOOP;
using Moq;

namespace InterfaceExample3.Tests
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_Ok()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(py => py.GetPower()).Returns(() => 0);
            //var fan = new DeskFan(new PowerSupplyThanZero());
            //ʹ��moq��
            var fan = new DeskFan(mock.Object);
            var expected = "won't work";
            var actual = fan.Work();

            Assert.Equal(expected, actual);


        }

        [Fact]
        public void PowerSupplyHigherThan200_Ok()
        {
            //var fan = new DeskFan(new PowerSupplyHigherThan200());
            //ʹ��moq��
            var mock = new Mock<IPowerSupply>();
            mock.Setup(fs => fs.GetPower()).Returns(() => 300);
            var fan = new DeskFan(mock.Object);
            var expected = "Explode!";
            var actual = fan.Work();

            Assert.Equal(expected, actual);
        }

        //ʹ��moq��ģ��

        /*class PowerSupplyThanZero : IPowerSupply
        {
            public int GetPower()
            {
                return 0;
            }
        }

        class PowerSupplyHigherThan200 : IPowerSupply
        {
            public int GetPower()
            {
                return 300;
            }
        }*/
    }
}
