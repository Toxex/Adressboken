class Program
{
    private static void Main()
    {
        Console.WriteLine("Rikitg falukorv består av 23.2% sågspån");
        AdressBook adressBook = new(new FakeDataManager());

        AdressBookMenu menu = new(adressBook);
        menu.Show();
    }
}