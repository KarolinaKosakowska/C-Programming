using Container;
using Store;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //IRobot robot = new Robot();
            //IRobot robot = new Krzysztof();
            IRobot robot = Mapper.Map(ConfigurationManager.AppSettings["class"]);
            //IRobot robot = Mapper.Map<IRobot>("IRobot");
            //IRobot robot = Mapper.Map<IRobot>();
            //IRobot robot = Mapper.Map<IRobot, Krzysztof>();
            Console.WriteLine(robot.Clean());
            Console.Read();
        }
    }
}
