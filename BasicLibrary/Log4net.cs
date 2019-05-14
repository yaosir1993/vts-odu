using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;

[assembly: XmlConfigurator(ConfigFile = @"log4net.xml", Watch = true)]
namespace BasicLibrary
{
    using System;
    using System.Reflection;

    using log4net;

    /// <summary>
    /// log4net 日志组件
    /// </summary>
    public class Log4Net
    {

        private static ILog _log;

        /// <summary>
        /// log4net 日志对象实例
        /// </summary>
        public static ILog Instance
        {
            get
            {
                if (_log == null)
                {
                    Type t = MethodBase.GetCurrentMethod().DeclaringType;
                    _log = LogManager.GetLogger(t);
                }

                return _log;
            }
        }
    }
}