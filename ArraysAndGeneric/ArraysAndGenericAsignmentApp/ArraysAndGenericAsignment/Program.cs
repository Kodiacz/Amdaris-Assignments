using ArraysAndGenericAsignment;


string[] items = new string[]
{
    "1",
    "2",
    "3",
    "4",
    "5",
};

ArrayList<string> arrayList = new ArrayList<string>(items);

ArrayList<int> secondArrayList = new ArrayList<int>()
{
    1,
    2,
    3,
};

arrayList.SetItemAtIndex("2", 1);

Console.WriteLine(string.Join(" ", arrayList.Array));

arrayList.SwapItems(3, 4);

Console.WriteLine(string.Join(" ", arrayList.Array));

arrayList.SwapItems("1", "5");

Console.WriteLine(string.Join(" ", arrayList.Array));

Console.WriteLine(arrayList.GetItemAtIndex(5));


