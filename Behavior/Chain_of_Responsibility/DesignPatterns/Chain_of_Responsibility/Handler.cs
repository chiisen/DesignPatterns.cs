namespace DesignPatterns.Chain_of_Responsibility
{
    /// <summary>
    /// 抽象處理者
    /// </summary>
    abstract class Handler
    {
        protected Handler? successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}
