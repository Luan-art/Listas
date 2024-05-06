using Listas;
using Listass;


List<Contact> li = new();

li.Add(new("luan", "123"));

foreach (Contact c in li)
{
    Console.WriteLine(c.ToString());
}

li.Add(new("Tales", "1234"));

li.Add(new("pestana", "1234"));

foreach (Contact c in li)
{
    Console.WriteLine(c.ToString());
}
  
    
li.Remove(li.Find(x => x.getNome() == "pestana"));

ContactList list = new ContactList();

Contact contact = new("bernado", "12123");

list.Add(contact);

Contact contactA = new("Ana", "12123");

list.Add(contactA);

Contact contactC = new("Caue", "12123");

list.Add(contactC);

Contact contactBr = new("Bruna", "12123");

list.Add(contactBr);

list.removeByName("Bruna");

Console.ReadKey();
