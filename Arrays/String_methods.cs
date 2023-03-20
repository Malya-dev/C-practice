
namespace evaluation
{
    public class string_methods
    {
        public void showstring()
        {
            String name = "Draganouv";

            String doublenum = "69.0987";

            System.Console.WriteLine(name);

            System.Console.WriteLine(doublenum);



            char[] ch = { 'V','A','L','O','R','A','N','T'};

            string game = new string(ch);

            System.Console.WriteLine(ch);

            System.Console.WriteLine(game.Length);

            string gamename = "sunquest";

            game = gamename;

            System.Console.WriteLine(game);



            // Methods of String



            String Name = "just do it ";

            // To_Upper

            System.Console.WriteLine(Name.ToUpper());



            // To_Lower

            System.Console.WriteLine(Name.ToLower());



            // Substring

            System.Console.WriteLine(Name.Substring(3));

            System.Console.WriteLine(Name.Substring(2, 7));



            // Replace

            foreach (char i in Name)

                System.Console.WriteLine(Name.Replace('O', 't'));

            System.Console.WriteLine(Name.Replace("Net", "Scope"));



            // Split with character

            string[] updated = Name.Split('e');

            // split with word

            string[] updated1 = Name.Split("Dot");

            foreach (string word in updated)

                System.Console.WriteLine(word);




            // Trim

            string trimmed = Name.Trim();

            System.Console.WriteLine(trimmed);



            // ToCharArray

            char[] spaces = { 's', 'p', 'a', 'c', 'e', 's' };

            char[] characters = Name.ToCharArray();

            System.Console.WriteLine("Characters : ");

            foreach (char ch1 in Name)

                System.Console.Write(ch + " ");



            // string Join

            string[] words = new string[] { "how", "are", "you" };

            string greet = string.Join("-", words);

            System.Console.WriteLine(greet);



            //  string equals

            string userInput = Console.ReadLine();

            string match = "possible";

            bool ans = userInput.Equals(match);

            System.Console.WriteLine(ans);



            // Starts with

            bool sw = Name.StartsWith("C");

            System.Console.WriteLine(sw);



            // Ends With

            bool ew = Name.EndsWith('s');

            System.Console.WriteLine(ew);



            // Contains

            bool con = Name.Contains("Net");

            System.Console.WriteLine(con);



            // Indexof char

            int indexofg = Name.IndexOf("G");

            System.Console.WriteLine(indexofg);

            //  index of word

            int indexofnet = Name.IndexOf("Net");

            System.Console.WriteLine(indexofnet);



            // LastIndexof

            int inx = Name.LastIndexOf("O");

            System.Console.WriteLine(inx);



            // Check null or Spaces.

            string user = Console.ReadLine()!;

            //bool nullcheck=string.IsNullOrEmpty(user);

            //System.Console.WriteLine(nullcheck);

            bool whitespace = string.IsNullOrWhiteSpace(user);

            System.Console.WriteLine(whitespace);



            // Format

            string subject = "operating system", dept = "mca";

            string message = string.Format("{0} is a subject of 5th sem in {1} ", subject, dept);

            System.Console.WriteLine(message);



            // Insert

            string newname = Name.Insert(6, "impossible is nothing");

            System.Console.WriteLine(newname);



            // Remove

            string remname = Name.Remove(1, 5);

            System.Console.WriteLine(remname);
        }
    }
}