using Common.Interfaces;

namespace Common.States
{
    public class Digitalizado : WorkflowManager, IStateProcess
    {
        public Digitalizado()
        {
            //TODO: cargar los atributos del estado
            this.ClassName = "Select * from state where StateName = " + GetType().Name;
        }

        public string Failure()
        {
            return this.StateFailureId;
        }

        public string Next()
        {
            return this.NextStateId;
        }
    }
}
