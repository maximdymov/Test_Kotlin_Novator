namespace Test_Kotlin_Novator
{
    class Checker
    {
        public static bool CheckCustomerInput(string name, string inn, string address)
        {
            return CustomerNameCheck(name) && InnCheck(inn) && AddressCheck(address);
        }

        public static bool CheckAccountInput(string account, string name, string bik, string balance)
        {
            return AccountCheck(account) && AccountNameCheck(name) && BikCheck(bik) && BalanceCheck(balance);
        }

        private static bool CustomerNameCheck(string name) => (name.Length <= 100 && name != "");
        private static bool InnCheck(string inn) => inn.Length == 12 && inn != "" && long.TryParse(inn, out long res);
        private static bool AddressCheck(string address) => address.Length <= 255;

        private static bool AccountNameCheck(string name)
        {
            if (name.Length <= 100) return true;

            if (name != "")
                foreach (var ch in name)
                    if (ch < 97 && ch > 122) return false;

            return true;
        }

        private static bool AccountCheck(string account) => account.Length == 20 && account != "" 
                                                        && decimal.TryParse(account, out decimal res);
        private static bool BikCheck(string bik) => bik.Length == 9 && bik != "" && int.TryParse(bik, out int res);
        private static bool BalanceCheck(string balance) => balance != "" && decimal.TryParse(balance, out decimal res);
    }
}
