using System.Reflection;

namespace SkilledCarryWeight.Extensions
{
    internal static class ReflectionUtils
    {
        public const BindingFlags AllBindings =
            BindingFlags.Public
            | BindingFlags.NonPublic
            | BindingFlags.Instance
            | BindingFlags.Static
            | BindingFlags.GetField
            | BindingFlags.SetField
            | BindingFlags.GetProperty
            | BindingFlags.SetProperty;
    }
}
