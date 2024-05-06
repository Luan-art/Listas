using Listas;
using Listass;

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