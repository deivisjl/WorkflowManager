using Common.Interfaces;
using System;

namespace Common.Process
{
    public class MyProcess : ProcessEntityBase
    {
        public MyProcess(string Id) : base(Id)
        {
            this.entityName = GetType().Name;
        }

        protected override void LoadWorkflow()
        {
            //TODO: cargar los atributos del documento a partir del Id
            this.sql = "Select * from workflows where process = " + this.entityName;
            this.className = sql.ToString();
            this.state = (IStateProcess)Activator.CreateInstance(Type.GetType(className));
        }

        protected override void MakeFailure()
        {
             this.state.Failure();
        }

        protected override void MakeSuccess()
        {
            //TODO: crear logica segun la condicion del estado
            this.state.Next();
        }
    }
}
