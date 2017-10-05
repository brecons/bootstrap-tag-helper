namespace BSolutions.Bocons.Extensions
{
    using BSolutions.Bocons.Enumerations;
    using BSolutions.Brecons.Core.Attributes.Enumerations;
    using System;
    using System.Linq;
    using System.Reflection;

    internal static class EnumExtensions
    {
        internal static ColorInfoAttribute GetColorInfo(this Color color)
        {
            MemberInfo memberInfo = color.GetType().GetMember(color.ToString()).FirstOrDefault();

            if (memberInfo != null)
            {
                return memberInfo.GetCustomAttribute<ColorInfoAttribute>();
            }

            throw new InvalidOperationException("It is not possible to read ColorInfoAttribute from enumeration.");
        }
    }
}
