namespace ZL.CSPlus
{
    public abstract class Component : ConsoleObject
    {
        protected SceneObject sceneObject;

        protected Component(SceneObject sceneObject)
        {
            this.sceneObject = sceneObject;
        }
    }
}