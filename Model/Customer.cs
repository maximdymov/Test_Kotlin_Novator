namespace Test_Kotlin_Novator
{
    class Customer : Model.IModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public long INN { get; private set; }
        public string Address { get; private set; }

        public Customer() : base()
        {

        }

        public override void SetParameters(string[] dataRow)
        {
            Id = int.Parse(dataRow[0]);
            Name = dataRow[1];
            INN = long.Parse(dataRow[2]);
            Address = dataRow[3];
        }
    }
}
