namespace Test_Kotlin_Novator
{
    class Account : Model.IModel
    {
        public int Id { get; private set; }
        public decimal account { get; private set; }
        public string Name { get; private set; }
        public int BIK { get; private set; }
        public decimal Balance { get; private set; }

        public Account() : base()
        {

        }

        public override void SetParameters(string[] dataRow)
        {
            Id = int.Parse(dataRow[0]);
            account = decimal.Parse(dataRow[1]);
            Name = dataRow[2];
            BIK = int.Parse(dataRow[3]);
            Balance = decimal.Parse(dataRow[4]);
        }
    }
}