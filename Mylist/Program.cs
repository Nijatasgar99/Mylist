//using system;
//using system.collections.generic;

//namespace mylist
//{
//    class program
//    {
//        static void main(string[] args)
//        {
             
//            list<users> contacts = new list<users>();
//            contacts.add(new users { name = "heyder", phonenumber = 4454545, age = 87 });
//            contacts.add(new users { name = "semed", phonenumber = 5509009, age = 70 });
//            contacts.add(new users { name = "elman", phonenumber = 7776688, age = 50 });
//            foreach (var users in contacts)
//            {
//                console.writeline(users.name);
//                console.writeline(users.age);
//                console.writeline(users.phonenumber);
//                console.writeline("_________________");
//            }
//            console.writeline("****************************");
//            contacts.insert(1, new users { name = "aqil", phonenumber = 45678524, age = 23 });
//            foreach (var users in contacts)
//            {
//                console.writeline(users.name);
//                console.writeline(users.age);
//                console.writeline(users.phonenumber);
//                console.writeline("_________________");
//            }
//            ______________________________________________________________________


//            list<string> country = new list<string>();
//            country.add("moskva");
//            country.add("istanbul");
//            country.add("baku");
//            foreach (var city in country)
//            {
//                console.writeline(city);
//            }
//            console.writeline("*************");
//            country.remove("moskva");
//            foreach (var city in country)
//            {
//                console.writeline(city);
//            }
//            console.writeline("*************");
//            country.insert(1, "berlin");
//            foreach (var city in country)
//            {
//                console.writeline(city);
//            }
//            +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//            int[] intarray = { 4, 6, 7, 8, 9, 5 };
//            list<int> intlist  = new list <int>();
//            intlist.addrange(intarray);
//            console.writeline(intlist.count);
//            console.readline();

//            __________________
//            string[] stringarray = { "seyx", "ezim", "sirvani" };
//            list<string> stringlist = new list<string>();
//            stringlist.addrange(stringarray);
//            console.writeline(stringlist.count);
//            console.readline();

//             biraz qarisiq olan &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
//            list<int> size = new list<int>() { 20, 10, 30 };
//            if (size.indexof(10)==1)
//            {
//                console.writeline("true");
//            }
//            else
//            {
//                console.writeline("false");
//            }

//            if (size.contains(30))
//            {
//                console.writeline("found");
//            }
//            else
//            {
//                console.writeline("not found");
//            }
//            size.add(39);
//            size.remove(20);
//            size.insert(2, 15);
//            size.clear();
//            console.writeline(size[0]);
//            console.writeline(size[1]);
//            console.writeline(size[2]);
//            console.writeline(size[3]);




//        }
//        class users
//        {
//            public string name { get; set; }
//            public int phonenumber { get; set; }
//            public int age { get; set; }

            
//        }

//    }
//}
