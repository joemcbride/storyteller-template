using StoryTeller.Engine;

namespace FUBUPROJECTNAME.StoryTeller
{
    public class FUBUPROJECTSHORTNAMESystem : ISystem
    {
        public void Dispose()
        {
        }

        public IExecutionContext CreateContext()
        {
            return new SimpleExecutionContext();
        }

        public void Recycle()
        {
        }
    }
}
