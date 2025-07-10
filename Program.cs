namespace shopwithui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tree ShopData = new Tree();
            Hash_Table UserData = new Hash_Table();
            Search search = new Search();
            ShopData.NilMaker();
            //ShopData.Read();
            //UserData.Read();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(ShopData, UserData, search));
        }
    }
}