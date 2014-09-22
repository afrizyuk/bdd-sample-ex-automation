using BDDSampleEx.Automation.Core;

namespace BDDSampleEx.Automation.Pages
{
    public class Page<T> where T : new()
    {
        //private static int instances;
        private static readonly T _instance = new T();

        public static T Instance()
        {
            return _instance;
        }
    }
}
