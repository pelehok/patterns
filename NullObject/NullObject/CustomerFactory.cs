namespace NullObject
{
    class CustomerFactory
    {
        public static string[] names = {"Rob", "joe", "Julie"};

        public static AbstractCustomer GetCustomer(string name){
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
