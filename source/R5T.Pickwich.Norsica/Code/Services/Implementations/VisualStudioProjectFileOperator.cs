using System;

using R5T.Norsica;
using R5T.Pickwich.Types;


namespace R5T.Pickwich.Norsica
{
    public class VisualStudioProjectFileOperator : IVisualStudioProjectFileOperator
    {
        private IDotnetOperator DotnetOperator { get; }
        private IVisualStudioProjectFilePathProvider VisualStudioProjectFilePathProvider { get; }


        public VisualStudioProjectFileOperator(IDotnetOperator dotnetOperator, IVisualStudioProjectFilePathProvider visualStudioProjectFilePathProvider)
        {
            this.DotnetOperator = dotnetOperator;
            this.VisualStudioProjectFilePathProvider = visualStudioProjectFilePathProvider;
        }

        public string CreateProjectFile(ProjectType projectType, string projectDirectoryPath, string projectName)
        {
            var projectTemplateShortName = projectType.ToProjectTemplateShortName();

            this.DotnetOperator.CreateNewProjectFile(projectTemplateShortName, projectDirectoryPath, projectName);

            var projectFilePath = this.VisualStudioProjectFilePathProvider.GetVisualStudioProjectFilePath(projectDirectoryPath, projectName);
            return projectFilePath;
        }
    }
}
