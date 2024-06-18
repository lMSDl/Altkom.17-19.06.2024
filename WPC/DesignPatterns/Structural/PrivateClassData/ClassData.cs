namespace WPC.DesignPatterns.Structural.PrivateClassData
{
    internal class ClassData
    {
        //private readonly int _intValue;
        //private string StringValue { get; }

        private PrivateClassData _privateClassData;

        public ClassData(int intValue, string stringValue)
        {
            //_intValue = intValue;
            //StringValue = stringValue;

            _privateClassData = new PrivateClassData(intValue, stringValue);
        }

        public void DoSth()
        {
            //_intValue = 0;
            //StringValue = "";

            _privateClassData.GetStringValue();
            _privateClassData.GetIntValue();
        }
    }
}
