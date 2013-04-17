namespace FirstTask
{
    using System;

    public class BoolVarToString
    {
        private const int MaxCount = 6;

        public static void Input()
        {
            BoolVarToString.Methods instance = new BoolVarToString.Methods();
            instance.BoolVarToString(true);
        }

        public class Methods
        {
            public void BoolVarToString(bool variable)
            {
                string variableToString = variable.ToString();
                Console.WriteLine(variableToString);
            }
        }
    }
}
