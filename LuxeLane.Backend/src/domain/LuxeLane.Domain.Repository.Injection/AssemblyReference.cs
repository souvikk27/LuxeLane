using System.Reflection;

namespace LuxeLane.Domain.Repository.Injection
{
    public class AssemblyReference
    {
        public Assembly Assembly { get; }

        public AssemblyReference(string assemblyName)
        {
            Assembly = Assembly.Load(assemblyName);
        }
    }

    public static class AssemblyReferenceFactory
    {
        public static AssemblyReference GetAssemblyReference(string assemblyName)
        {
            return new AssemblyReference(assemblyName);
        }
    }
}
