using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story_Rukavichka
{
    class MagicAnimals
    {
        public string Name { get; set; }
        public MagicAnimals(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class MagicHeroes
    {
        public string Name { get; set; }
        public MagicHeroes(string name)
        {
            Name = name;
        }
    }
    class Story
    {
        List<MagicAnimals> AnimalsList = new List<MagicAnimals>();
        List<MagicHeroes> HeroesList = new List<MagicHeroes>();
        List<MagicAnimals> Rukavichka = new List<MagicAnimals>();
        public void CreateAnimalsList()
        {
            AnimalsList.Add(new MagicAnimals("Мышка-поскребушка"));
            AnimalsList.Add(new MagicAnimals("Лягушка-попрыгушка"));
            AnimalsList.Add(new MagicAnimals("Зайчик-побегайчик"));
            AnimalsList.Add(new MagicAnimals("Лисичка-сестричка"));
            AnimalsList.Add(new MagicAnimals("Волчок-серый бочок"));
            AnimalsList.Add(new MagicAnimals("Кабан-клыкан"));
            AnimalsList.Add(new MagicAnimals("Медведюшка-батюшка"));
        }
        public void CreateHeroesList()
        {
            HeroesList.Add(new MagicHeroes("Дедушка"));
            HeroesList.Add(new MagicHeroes("Собачка"));
        }
        public void Begin()
        {
            Console.WriteLine("Шёл {0} лесом, а за ним бежала {1}.", HeroesList[0].Name, HeroesList[1].Name);
            Console.WriteLine("Шёл {0}, шёл, да и обронил рукавичку.", HeroesList[0].Name);
        }
        private void AddingToRukavichka(int c)
        {
            for (int i = 1; i < c; i++)
            {
                Console.WriteLine("Вот бежит {0}, подбегает к рукавичке и спрашивает:", AnimalsList[i].Name);
                Console.WriteLine("- Кто-кто в рукавичке живёт?");
                for (int j = 0; j < Rukavichka.Count; j++)
                {
                    Console.WriteLine("- Я {0}. ", Rukavichka[j]);
                }
                Console.WriteLine("- А ты кто?");
                Console.WriteLine("- А я {0}, пустите меня!", AnimalsList[i]);
                Console.WriteLine("- Ну иди!");
                Rukavichka.Add(AnimalsList[i]);
                Console.WriteLine("И вот уже их {0}, но вдруг...", Rukavichka.Count);
            }
        }
        private void StoryWithSix(int c)
        {
            AddingToRukavichka(c);
            Console.WriteLine("Откуда ни возьмись, бредёт {0}:", AnimalsList[5].Name);
            Console.WriteLine("- Хро-хро-хро, в рукавичке живёт?");
            for (int j = 0; j < Rukavichka.Count; j++)
            {
                Console.WriteLine("- Я {0}. ", Rukavichka[j]);
            }
            Console.WriteLine("- А я {0}, пустите меня!", AnimalsList[5].Name);
            Console.WriteLine("Вот беда, всем в рукавичку охота.");
            Console.WriteLine("- Тебе и не влезть!");
            Console.WriteLine("- Как-нибудь влезу, пустите!");
            Console.WriteLine("- Ну, что ж с тобой поделаешь, лезь!");
            Rukavichka.Add(AnimalsList[5]);
            Console.WriteLine("И вот уже их {0}, И так им тесно, что не повернуться!", Rukavichka.Count);

        }
        private void StoryWithSeven(int c)
        {
            StoryWithSix(c);
            Console.WriteLine("А тут затрещали сучья: вылезает медведь и тоже к рукавичке подходит, ревет:"
                , AnimalsList[6].Name);
            Console.WriteLine("- Ктооо, ктооо в рукавичке живет??");
            for (int j = 0; j < Rukavichka.Count; j++)
            {
                Console.WriteLine("- Я {0}. ", Rukavichka[j]);
            }
            Console.WriteLine("- Гу-гу-гу, вас тут многовато! А я {0}, пустите меня!", AnimalsList[6].Name);
            Console.WriteLine("- Как же мы тебя пустим? Ведь и так тесно.");
            Console.WriteLine("- Да как-нибудь!");
            Console.WriteLine("- Ну уж иди, только с краешку!");
            Rukavichka.Add(AnimalsList[6]);
            Console.WriteLine("И вот уже их {0}, да так тесно, что рукавичка того и гляди, разорвется."
                , Rukavichka.Count);
        }
        private void End()
        {
            Console.WriteLine("А тем временем {0} схватился - нет рукавички, А {1}, вперед побежала."
                , HeroesList[0].Name, HeroesList[1].Name);
            Console.WriteLine("{0} тогда: - Гав, гав!", HeroesList[1].Name);
            Console.WriteLine("Звери испугались, из рукавички выбежали да врассыпную по лесу...");
            
        }
        private void AlternativeEnd()
        {
            Console.WriteLine("А тем временем {0} схватился - нет рукавички, А {1}, вперед побежала."
                , HeroesList[0].Name, HeroesList[1].Name);
            Console.WriteLine("{0} тогда: - Гав, гав!", HeroesList[1].Name);
            Console.WriteLine("Идет {0}, видит: рукавичка шевелится. Он как стрельнет — вот сколько шкур-то!"
                , HeroesList[0].Name);
        }
        public void StartStoryRukavichka(int c)
        {
            Console.WriteLine("Вот бежит {0} влезла в рукавичку и сказала:", AnimalsList[0].Name);
            Console.WriteLine("- Здесь я буду жить!");
            Rukavichka.Add(AnimalsList[0]);
            if (c <= 5)
            {
                AddingToRukavichka(c);
                End();
            }
            else if (c == 6)
            {
                StoryWithSix(c);
                End();
            }
            else
            {
                StoryWithSeven(c);
                AlternativeEnd();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int c = random.Next(1, 7);
            Story story = new Story();
            story.CreateAnimalsList();
            story.CreateHeroesList();
            story.Begin();
            story.StartStoryRukavichka(c);
            
        }
    }
}
