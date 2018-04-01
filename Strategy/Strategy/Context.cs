namespace Strategy
{
    class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy){
            this._strategy = strategy;
        }

        public int ExecuteStrategy(int num1, int num2){
            return _strategy.DoOperation(num1, num2);
        }
    }
}
