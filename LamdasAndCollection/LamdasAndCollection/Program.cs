var heros = new List<Hero> { 
new("a","a","aa",false),
new("b","b","bb",true),
new(String.Empty,String.Empty,"cc",true)

};

var herosWhoCanFly = Filter(heros, h => h.canfly);

Console.WriteLine(String.Join(", ", herosWhoCanFly));

var herosWithLastNameEmpty = Filter(heros, h => String.IsNullOrEmpty(h.lastName));

Console.WriteLine(String.Join(", ", herosWithLastNameEmpty));



var str = Filter(new[] { 1, 2, 3, 4, 6 }, h => h % 2 == 0);




Console.WriteLine(String.Join(", ",str));





static IEnumerable<T> Filter<T>(IEnumerable<T> items, Filter<T> filter)
{
   // var x = new List<T>();
   foreach(var item in items)
    {
        if (filter(item))
        {
            yield return item;
        }
    }

   // return x;
}


heros.Add(new Hero("a", "b", "c", true));

//Console.WriteLine(heros.ToList());



delegate bool Filter<T>(T hero);

record Hero(string FirstName,string lastName,string heroName,bool canfly);







