
using System.Reflection;

namespace LuxeLane.Domain.Persistance
{
    public static class AssemblyReference
    {
        public static readonly Assembly assembly = typeof(AssemblyReference).Assembly;
        public static readonly Assembly ExecutingAssembly = Assembly.GetExecutingAssembly();
    }
}
