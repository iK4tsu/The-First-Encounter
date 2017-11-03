using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_First_Encounter___TBG
{
    class Game
    {
        //Text Color
        //Gray: Story test
        //Red: When something bad is happening
        //Cyan: When a player needs to make a choice
        //Yellow: Display player choices
        //Magenta: When player speaks or thinks something

        static string playerchoice;
        static string playername;
        static int textspeed = 10;
        

        static void Main(string[] args)
        {
            //Introduction();
            //Menu();
            Part1();
            Part2();
        }

        private static void Introduction()
        {
            Console.ForegroundColor = ConsoleColor.Gray;           
            string[] introduction = new string[] { "Welcome to my text based game.",
                "This adventure game is weird, so don't be surprised when you see some things that are... hmmm... not normal?",
                "I hope you enjoy this game as much I enjoyed making it.",
                "This is my first 'real' project in C#, so I'm hopping this game is at least decent.",
                "I'm sorry for any inconvinience in the writting, english isn't my native language.",
                "So if you see a word or a sentence not well written, that can possible be the reason why.",
                "But enough chit chat; let's play the game.","","Press 'Enter' to continue..." };
            for (int i = 0; i < introduction.Length; i++)
            {
                foreach ( char c in introduction[i])
                {
                    Console.Write(c);
                    Thread.Sleep(25);
                }
                Thread.Sleep(750);
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("The First Encounter (made by Katsu)\n\n1. Play\n2. Settings\n3. Exit\n");
            playerchoice = Console.ReadLine().ToLower();
            switch (playerchoice)
            {
                case "play":
                case "1":                  
                    break;
                case "2":
                case "settings":
                    Console.Clear();
                    Console.WriteLine("Text speed: Slow, Medium, Fast, To fast for you");
                    Console.Write("Choose your text spped: ");
                    playerchoice = Console.ReadLine().ToLower();
                    if (playerchoice == "slow")
                        textspeed = 100;
                    else if (playerchoice == "medium")
                        textspeed = 50;
                    else if (playerchoice == "fast")
                        textspeed = 25;
                    else if (playerchoice == "to fast for you")
                        textspeed = 10;
                    else
                    {
                        Console.WriteLine("Unknown choice. Try again.");
                        Thread.Sleep(1000);
                        goto case "2";
                    }                        
                    Menu();
                    break;
                case "exit":
                case "3":
                    GameOver();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Can't recognize command! Please try again...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(1000);
                    Menu();
                    break;
            } 
        }

        private static void Part1()
        {
            Console.Clear();
            string chapter1 = "Chapter 1 - Total failure";
            string[] dynamictext = new string[] { "You wake up in a strange place.",
                "You try to recognize this place, but you can't even think beacause there's just to much noise arround you.","Your vision is still blurry.",
                "You start raising your head slowly and you hear a mens voice getting louder and louder.",
                "It appears to be calling your name, but... what is your name again?","" };
            Console.SetCursorPosition(Console.WindowWidth / 2 - chapter1.Length / 2, 0);
            Console.WriteLine(chapter1 + "\n");
            for (int i = 0; i < dynamictext.Length; i++)
            {
                foreach (char c in dynamictext[i])
                {
                    Console.Write(c);
                    Thread.Sleep(textspeed);
                }
                Thread.Sleep(750);
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Your name: ");
            playername = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n_");
            foreach (char c in playername.ToUpper())
            {
                Console.Write(c);
                Thread.Sleep(textspeed);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
            dynamictext = new string[] { "This time the scream when this men called your name was so loud, you jumped out of your sit.",
                "","_I see you're having fun in my class " + playername + ". What have you learn today? I'm gessing not much since you were asleep during MY HOLE CLASS!",
                "","You remember where you are. You are in Mr.S's class!",
                "","This is bad (you think).",
                "","He's probably the worst teacher in this school when it comes to not paying attention in his class.",
                "One time he got a student to drink toilet water just for laughing of the fact Mr.S was wearing spiderman's underwear!",
                "He's a teacher bully! And you've just fell asleep in his class! You are shaking so much, it's just like you've unlocked a new dancing move.",
                "You're so afraid, your body blocks all comunication coming from the outside.",
                "You're looking to Mr.S's face and you see his lips moving, but you can't hear anything.",
                "You must think of something to escape his horrible punishment!",
                "But in this moment all you could think about was 'don't cry' and 'don't pee yourself'!",
                "This is probably not the best way to escape this guy's punishement, but nothing else comes to mind.",
                "","Is this it? Am I gonna die in this shit hole school? There's so much I wanna do, I... I... I CAN'T DIE NOW NOR TODAY! I MUST FIND A WAY TO GET RID OF THIS SITUATION! Even... EVEN IF I HAVE TO PEE MYSELF OUT OF THIS! - you thought.",
                "","Your self conscience motivation speech has given you the courage to react.","","Press 'Enter' to continue..." };
            for (int i = 0; i < dynamictext.Length; i++)
            {
                if (i == 2)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (i == 6 || i == 17)
                    Console.ForegroundColor = ConsoleColor.Magenta;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;
                foreach (char c in dynamictext[i])
                {
                    Console.Write(c);
                    Thread.Sleep(textspeed);
                }
                Thread.Sleep(750);
                Console.WriteLine("");
            }
            Console.ReadLine();
            bool valid = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Pee yourself\n2. Cry\n3. Punch him\n4. Run for your life");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("What do you do? ");
                playerchoice = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Gray;
                switch (playerchoice)
                {
                    case "1":
                    case "pee":
                    case "pee yourself":
                        Console.Clear();
                        dynamictext = new string[] { "You were so afraid, you couldn't hold it any longer... you were weak.",
                            "The pee started flowing through your legs, until it reached the floor.",
                            "","_Are you... Did you just... WHAT THE FUCK IS WRONG WITH YOU " + playername.ToUpper() + "? YOU RETARDED FUCK! LOOK AT WHAT YOU'VE JUST DONE! ARE YOU FUCKING KIDDING ME? GET THE FUCK OUT OF HERE YOU PIECE OF SHIT! I WOULD KICK YOUR ASS RIGHT NOW, BUT I DON'T WANT TO GET PISS DESEASE.",
                            "","No one in the class did anything. No one laughed nor commented this situation. Not a single reaction was made.",
                            "They knew if they did anything, they would be the ones getting their asses kicked.",
                            "But more importantly, you've just gotten out of this shit situation! And your classmates knew that too!",
                            "No one until this moment has ever had escaped that maniac's punishment. You were the first!",
                            "After realising that, all you wanted to do was walk out and laugh, but you couldn't yet, you need to stay i charater.",
                            "You needed to stay embaraced for peeing yourself until you were outside that door.",
                            "It was so difficult to act embaraced, because of how much you were prowd of yourself!",
                            "This would be the story you would tell to the future generations! Everyone would remember you!",
                            "'The guy who peed himself to escape Mr.S's punishment'. What a great story!",
                            "The 7 seconds you needed to get out of the class looked like an hour. But you did it!",
                            "You walked out of that hell without showing how proud you actualy were!","","Press 'Enter' to continue..." };
                        for (int i = 0; i < dynamictext.Length; i++)
                        {
                            if (i == 3)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = ConsoleColor.Gray;
                            foreach (char c in dynamictext[i])
                            {
                                Console.Write(c);
                                Thread.Sleep(textspeed);
                            }
                            Thread.Sleep(750);
                            Console.WriteLine("");
                        }
                        Console.ReadLine();
                        valid = true;
                        break;
                    case "2":
                    case "cry":
                        Console.Clear();
                        dynamictext = new string[] { "The tears started droping to your face. You lost all the strength, and you fell on your knees.",
                            "At this moment you knew you were fucked. Mr.S would never forgive you for sleeping in his class.",
                            "All hope was gone.",
                            "","_Is that all you've got kiddo? Come one, get up. Don't be like that. This can happen to anyone!",
                            "","What was this? Was Mr.S serious right now? Normaly in this situations the guy who fucked up was already unconscious!",
                            "Maybe this was your lucky day! Maybe Mr.S was in a good mood today, and he was about to forgive you!",
                            "","_Come " + playername + ". Let's go outside to talk for a little bit.",
                            "","This situation didn't felt right. You knew something bad was about to happen. Mr.S would never be this kind to anyone.",
                            "You got up and started walking to the classroom door, but before you got there, Mr.S grabbed the back of your head and...",
                            "","_THIS IS WHAT HAPPENS TO EVERYONE WHO DOESN'T PAY ATTENTION IN MY CLASS!",
                            "He smashed your face into the nearest table. You got instantly unconscious.","","Press 'Enter' to continue..." };
                        for (int i = 0; i < dynamictext.Length; i++)
                        {
                            if (i == 4 || i == 9 || i == 14)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = ConsoleColor.Gray;
                            foreach (char c in dynamictext[i])
                            {
                                Console.Write(c);
                                Thread.Sleep(textspeed);
                            }
                            Thread.Sleep(750);
                            Console.WriteLine("");
                        }
                        Console.ReadLine();
                        valid = true;
                        GameOver();
                        break;
                    case "3":
                    case "punch him":
                        Console.Clear();
                        dynamictext = new string[] { "You couldn't take it any longer. You were done with Mr.S and with that atitude of hims.",
                            "Those emotions started turning into anger, and your blood started boiling under your skin.",
                            "You waited for the right moment to strike. When you felt the right moment, you raised your face.",
                            "Your eyes locked on Mr.S's face. You raised your arm, and you swang it in it's direction.",
                            "What a mistaque you've made. You should know, you couldn't ever win against Mr.S.",
                            "But the anger inside you was so big, you didn't even think about it.",
                            "As your fist was reaching Mr.S's face, you couldn't believe what was happening.",
                            "The little shit knew martial arts! And he was good at them to!",
                            "He blocked your attack with one arm, and then, with the oposit arm, he grabed it, and turned you arround.",
                            "","_Do you think you can beat me in a fight? You realy are a fucktard. THIS IS WHAT YOU DESERVE FOR BEING TO COCKY!",
                            "","_AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH.",
                            "","He aplied force to your arm and broke it. The pain was so intense, you were about to faint!",
                            "But your body and mind wouldn't let you, and you ketp experiencing that awfull pain.",
                            "Mr.S then finish you off, by kicking you in the stomach first, and then in your face.",
                            "You got instantly unconscious.","","Press 'Enter' to continue..." };
                        for (int i = 0; i < dynamictext.Length; i++)
                        {
                            if (i == 10)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else if (i == 12)
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            else
                                Console.ForegroundColor = ConsoleColor.Gray;
                            foreach (char c in dynamictext[i])
                            {
                                Console.Write(c);
                                Thread.Sleep(textspeed);
                            }
                            Thread.Sleep(750);
                            Console.WriteLine("");
                        }
                        Console.ReadLine();
                        valid = true;
                        GameOver();
                        break;
                    case "4":
                    case "run":
                    case "run for your life":
                        Console.Clear();
                        dynamictext = new string[] { "You body starts filling with adrenaline.",
                            "You look at the the door across the classroom, and you think the only way for you to get out that is to run.",
                            "You start preparing yourself fisicaly and mentaly to run as soon as you find an opportunity.",
                            "Time passed. Mr.S was speaking to you but you couldn't hear him.",
                            "You were to focused, trying to finda the right moment to escape.",
                            "The had finaly come. You made a mentaly count down.",
                            "","3... 2... 1... NOW!",
                            "","You ran as fast as you could to the classroom door, but before you got there, Mr.S grabbed the back of your head and...",
                            "","_THIS IS WHAT HAPPENS TO EVERYONE WHO DOESN'T PAY ATTENTION IN MY CLASS!",
                            "He smashed your face into the nearest table. You got instantly unconscious.","","Press 'Enter' to continue..." };
                        for (int i = 0; i < dynamictext.Length; i++)
                        {
                            if (i == 11)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else if (i == 7)
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            else
                                Console.ForegroundColor = ConsoleColor.Gray;
                            foreach (char c in dynamictext[i])
                            {
                                Console.Write(c);
                                Thread.Sleep(textspeed);
                            }
                            Thread.Sleep(750);
                            Console.WriteLine("");
                        }
                        Console.ReadLine();
                        valid = true;
                        GameOver();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nUnknown command, please try again.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\nPress 'Enter' to continue...");
                        Thread.Sleep(1000);
                        break;
                } 
            } while (!valid);
        }



        private static void Part2()
        {

        }

        private static void Part3()
        {

        }

        private static void GameOver()
        {
            Console.Clear();
            Menu();           
        }
    }
}
