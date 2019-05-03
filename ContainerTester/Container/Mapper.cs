using Store;
using System;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public static class Mapper
    {
        private static Assembly storeAssembly = typeof(IRobot).Assembly;
        public static dynamic Map(string name)
        {
            try
            {
                var type = storeAssembly.GetType($"Store.{name}");
                return type.GetConstructor(new Type[] { }).Invoke(new object[] { });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// Zwraca obiekt po nazwie
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static dynamic Map<T>(string name) where T : IRobot
        {
            //name = name.Replace("I", "");
            name = name.Substring(1, name.Length - 1);
            var type = storeAssembly.GetType($"Store.{name}");
            return type.GetConstructor(new Type[] { }).Invoke(new object[] { });
        }
        public static dynamic Map<T>() where T : IRobot
        {
            string name = typeof(IRobot).Name;
            name = name.Substring(1, name.Length - 1);
            var type = storeAssembly.GetType($"Store.{name}");
            return type.GetConstructor(new Type[] { }).Invoke(new object[] { });
        }
               
        public static TClass Map<TInterface, TClass>()
        {
            if (typeof(TInterface).IsAssignableFrom(typeof(TClass)))
            {
                var type = storeAssembly.GetType($"Store.{typeof(TClass).Name}");
                return (TClass)type.GetConstructor(new Type[] { }).Invoke(new object[] { });
            }
            throw new ArgumentException("TClass is not implementing TInterface");
        }  
        static T getObject<T>()
        {
            return (T)typeof(T).GetConstructor(new Type[] { }).Invoke(new object[] { });
        }
    }

}
