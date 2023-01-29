using FuncDemoConsole;

var demoStores = new List<Store>() {
    new Store(1,"US","Main"),
    new Store(2,"US","Second"),
    new Store(3,"US","Best"),
    new Store(4,"RU","Glavniy"),
    new Store(5,"RU","Vecher"),
    new Store(6,"RU","Moscow"),
    new Store(7,"UA","Golovniy"),
    new Store(8,"UA","Kyiv"),
};

var stores = new Stores(demoStores);

var americanStores = stores.GetFilteredStores(s => s.CountryCode == "US");

foreach (var s in americanStores)
    Console.WriteLine($"{s.CountryCode} - {s.Name}");


