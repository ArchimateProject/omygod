using Structurizr;
using ScriptEngine.Machine.Contexts;

namespace OMyGod
{
    [ContextClass("ПредставленияРабочегоПространства", "WorspacesViews")]
    public class ViewsImpl : AutoContext<ViewsImpl>
    {
        private Workspace _createdWorkspace;

        [ContextMethod("СоздатьПредставлениеРазвертывания", "CreateDeploymentView")]
        public DeploymentViewImpl CreateDeploymentView(SoftwareSystemImpl system,
            string key, string description)
        {
            return new DeploymentViewImpl(
                _createdWorkspace.Views.CreateDeploymentView(
                    system.link, key, description 
                )
            );
        }

        [ContextMethod("ДобавитьСтильЦветаЭлементу", "AddColorStyleToElement")]
        public void AddColorStyleToElement(string _value)
        {
            _createdWorkspace.Views.Configuration.Styles.Add(
                new ElementStyle(Tags.Element) {
                    Color = _value
                }
            );
        }

        public ViewsImpl(Workspace createdWorkspace)
        {
            _createdWorkspace = createdWorkspace;
        }
    }
}