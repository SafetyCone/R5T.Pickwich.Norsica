using System;

using R5T.Magyar;
using R5T.Pickwich.Types;


namespace R5T.Pickwich.Norsica
{
    public static class ProjectTypeExtensions
    {
        public static string ToProjectTemplateShortName(this ProjectType projectType)
        {
            switch(projectType)
            {
                case ProjectType.Console:
                    return "console";

                case ProjectType.Library:
                    return "classlib";

                case ProjectType.Test:
                    return "mstest";

                default:
                    throw new Exception(EnumerationHelper.UnexpectedEnumerationValueMessage(projectType));
            }
        }
    }
}
