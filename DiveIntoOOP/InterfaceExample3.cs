using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiveIntoOOP
{
    class InterfaceExample3
    {
    }

    public interface IPowerSupply
    {
        int GetPower();
    }

    public class PowerSupply : IPowerSupply
    {
        public int GetPower()
        {
            //单元测试 不能每次都修改这个值 用方法打印来测试
            //创建一个单元测试类
            return 110;
        }
    }

    public class DeskFan
    {
        private IPowerSupply powerSupply;
        public DeskFan(IPowerSupply powerSupply)
        {
            this.powerSupply = powerSupply;
        }

        public string Work()
        {
            if (powerSupply.GetPower() <= 0)
            {
                return "won't work";
            }
            else if (powerSupply.GetPower() <= 100)
            {
                return "Slow";
            }
            else if(powerSupply.GetPower() <= 200)
            {
                return "Work Fine";
            }
            else
            {
                return "Explode!";
            }
        }
    }
}
