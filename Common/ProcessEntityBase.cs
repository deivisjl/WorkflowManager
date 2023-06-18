namespace Common.Interfaces
{
    public abstract class ProcessEntityBase
    {
		protected string entityName;
		protected IStateProcess state;
		protected string sql;
		protected string Id;
		protected string className;
		protected string workflowId;

		public ProcessEntityBase(string _Id)
        {
			this.Id = _Id;
        }
		protected abstract void LoadWorkflow();
		protected abstract void MakeSuccess();
		protected abstract void MakeFailure();
	}
}
