namespace Common
{
    public abstract class WorkflowManager
    {
		protected string Id;
		protected string StateName;
		protected string StateColor;
		protected string StateAlias;
		protected string NextStateId;
		protected string StateFailureId;
		protected string ClassName;
		protected string Conditional;
		protected string WorkflowId;

		public WorkflowManager()
        {}
	}
}
