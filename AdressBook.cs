using System.Collections.ObjectModel;
using System.Text.Json;

class AdressBook
{
    public int Count { get => _contacts.Count; }
    readonly List<Contact> _contacts = new();

    public void AddContact(Contact contact)
    {
        int lastId = 0;
        _contacts.ForEach(c => lastId = c.Id > lastId ? c.Id : lastId);
        contact.Id = lastId + 1;
        _contacts.Add(contact);
    }

    public ReadOnlyCollection<Contact> GetAllContacts()
    {
        return new ReadOnlyCollection<Contact>(_contacts);
    }

    public void Save()
    {
        string jsonData = JsonSerializer.Serialize(_contacts);
        File.WriteAllText("contacts.json", jsonData);
    }
}