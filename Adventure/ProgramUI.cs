using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class ProgramUI
    {
        private AdventureRepository adventureRepo = new AdventureRepository();
        private Hero hero = new Hero();



        public void Run()
        {
            PlayGame();
            StartAdventure();
            EndGame();
        }

        private void PlayGame()
        {
            Console.WriteLine("Welcome to Adventure Time!");
            Console.ReadLine();
            Console.WriteLine("You will be exploring the land of The Fair Born. What is your name, Adventurer?");

            Create();
            PlayerPrompt();
        }

        private void Create()
        {
            string name = Console.ReadLine();
            adventureRepo.CreateHero(name);
            Console.WriteLine("Well met, " + name + "!");
            Console.ReadKey();
        }

        private void PlayerPrompt()
        {
            var hero = adventureRepo.CharacterDetails();
            Console.Clear();
            bool cont = true;

            while (cont)
            {
                Console.WriteLine($"What would you like to do?\n" +
                "1. Learn about my character.\n" +
                "2. Start Adventure");
                string inputString = Console.ReadLine();

                switch (inputString)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Your name is { hero.Name }. Your objective is to outwit your captors and wear down their Energy before your own Energy reaches 0. You begin with an Energy value of 7. The Energy of your captors is unknown. You will encounter many mysterious creatures and events throughout your journey. The choices you make in these encounters will increase or decrease either your Energy or the Energy of your captors, so choose wisely!");
                        break;
                    case "2":
                        StartAdventure();
                        break;
                    default:
                        break;
                }
            }
        }

        private void StartAdventure()
        {
            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.WriteLine("You wake up. The room is dark. Light creeps in from a door in the far corner. You try to crawl towards it, but as your eyes adjust to the dark you see bars in front of you. You are in a cage. What do you do?\n" +
                    "1. Try to escape.\n" +
                    "2. Call for help.\n" +
                    "3. Energy status");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("You look up and realize that, though the bars reach far above your head, your cage has no ceiling. You try to climb, but the bars are too high and you fall to the ground. You cry out in frustration, but you suddenly fall silent when you hear heavy footsteps from beyond the far door.");
                        Console.ReadLine();
                        GiantEncounter();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You examine your surroundings. To your left, you see your companion, Red. You whisper to him, but he doesn't respond. Typical Red. You call louder. Still, no answer. You call as loud as you dare, but you suddenly fall silent when you hear heavy footsteps from beyond the far door.");
                        Console.ReadLine();
                        GiantEncounter();
                        break;
                    case "3":
                        adventureRepo.CharacterDetails();
                        Energy();
                        break;
                    default:
                        break;
                }
            }
        }

        private void GiantEncounter()
        {
            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.WriteLine($"Your cries have called the attention of your captor! As the door swings open you see him for the first time. He towers above you... 3, maybe 4 times your own height. He looks down at you with a large, toothy grin and says something in a language you don't understand. Much to your surprise, the giant reaches down and lifts you high above the bars of your cell. Holding you in his arms, he turns and carries you towards the door. He does not appear to be aggressive...\n" +
                $"1.  You can't be too careful. You must escape!\n" +
                $"2.  You don't appear to be in any immediate danger, and this is an excellent opportunity to gather intel. You wait to see where the giant will take you.");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        adventureRepo.DecreaseEnergy();
                        Red();
                        break;
                    case "2":
                        Intel();
                        break;
                    case "3":
                        Energy();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Red()
        {
            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.WriteLine($"As soon as the giant carries you from the room you begin to fight, desperate to escape his clutches. You succeed in intimidating your captor, who lowers you to the ground. As you prepare to take flight you realize: Red! Red did not make it out of the room where you were held captive! What do you do?\n" +
                    $"1. No man left behind!\n" +
                    $"2. Every man for himself!\n" +
                    $"3. Check Energy");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                switch(input)
                {
                    case 1:
                        RedRescue();
                        break;
                    case 2:
                        TheBeast();
                        break;
                    case 3:
                        Energy();
                            break;
                    default:
                        break;
                }
            }
        }

        private void RedRescue()
        {
            Console.Clear();
            Console.WriteLine("Sorry, adventurer! This path is not functional yet");
            Console.ReadLine();
            Red();
        }

        private void TheBeast()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Red is a strong warrior... he will be able to fend for himself. You run down the passageway away from the giant, frantically seeking an exit before your captor gathers his senses and makes chase. You stop dead in you tracks as the passageway opens into a large cavern. Laying right in front of you, blinking its eyes and yawning as it wakes, is the largest beast you have ever seen. You might have described it as a wolf, but it is far larger than any wolf, with its back reaching your own height. He opens his eyes and the two of you lock eyes. You both freeze.\n" +
                    "\n" +
                    "1. Attack before the Beast can attack you!\n" +
                    "2. Tame the Beast.\n" +
                    "3. Check Energy");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                switch(input)
                {
                    case 1:
                        adventureRepo.DecreaseEnergy();
                        adventureRepo.DecreaseEnergy();
                        AttackBeast();
                        break;
                    case 2:
                        adventureRepo.DecreaseEnergy();
                        adventureRepo.DecreaseEnergy();
                        TameBeast();
                        break;
                    case 3:
                        Energy();
                        break;
                    default:                        
                        break;
                }
            }
        }

        private void AttackBeast()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sorry, adventurer! This path is not functional yet");
                Console.ReadLine();
                TheBeast();
            }
        }

        private void TameBeast()
        {
            Console.Clear();
            Console.WriteLine("'Good boy,' you mutter hopefully, extending your hand for it to sniff. It stares. You cautiously step forward, soliciting a low growl from the Beast. Digging deep into the last of your magical Energy you put all your will into calming the Beast as you gently lay your palm on its forehead. The beast blinks and shakes its head, trying to shake off the affects of your magic, but before you can complete the spell your concentration is broken by a crash behind you. With a roar the beast breaks free of the trance and runs. You whip around to face whatever new threat lays ahead, but your eyes are heavy and your head is spinning. You must have used the last of your energy trying to tame the beast. You fight as hard as you can to remain conscious... through blurry vision you see the giant breaking into the cavern, reaching down towards you...");
            Console.ReadLine();
            EndGame();
            
        }

        private void Intel()
        {
            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.WriteLine($"The giant carries you down a narrow hallway and into a large room. The giant is holding you so high up that you have a clear view of your surroundings. You see massive tables, large enough to sit many giants, and with an uneasy feeling you realize that there may be more than one giant in your captor's lair.\n" +
                    "The giant carries you towards one of the large tables, and on it you see a sharp broadsword. Well, it must appear to be just a knife to the giant, but such technicalities become irrelevant when you see that it is still caked with a red, sticky fluid that looks uncomfortably like blood. What do you do?\n" +
                    "1. You need more information to make an informed escape, but a weapon would be useful...\n" +
                    "2. This weapon bodes ill. You must escape by any means possible, even if it means resorting to magic.\n" +
                    "3. Check Energy");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                switch (input)
                {
                    case 1:
                        //Refactor This
                        adventureRepo.DecreaseEnergy();
                        adventureRepo.DecreaseEnergy();
                        StealWeapon();
                        break;
                    case 2:
                        //Refactor This
                        adventureRepo.DecreaseEnergy();
                        adventureRepo.DecreaseEnergy();
                        ShapeShift();
                        break;
                    case 3:
                        Energy();
                            break;
                    default:
                        break;
                }
            }
        }

        private void StealWeapon()
        {
            Console.Clear();
            Console.WriteLine("Sorry, adventurer! This path is not functional yet");
            Console.ReadLine();
            Intel();
        }

        private void ShapeShift()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"You wrack your brain for all of the spells your parents taught you when you were young. Memories swirl in your mind of sitting on your mother's knee looking in wonder at the intricate illustrations in her spellbooks. You remember standing in your father's office gazing in awe at the statuettes commemorating his battles from his younger years. You see vicious orcs, decrepid undead soldiers, and... your eyes snap open as you recognize the spell you need to cast.\n" +
                    "It appears the giant is preparing some sort of dark ritual. He is speaking to you in a low voice in a tongue you don't understand as he dips his knife into an entire vat of congealing blood. You can't waste any time. You will not be his next victim. You close your eyes you focus your mind in preparation for the spell. You summon thoughts of far-off mountains, gold, and fire. You feel heat rise in your chest and hard, rough armor spread across your body. With a mighty roar you spread your mighty wings, a fully transormed dragon!\n" +
                    "The giant roars in rage and tries to cling to you, but with another roar you channel all the heat in your dragon body and breathe fire on the giant. Roaring in rage it releases you and you take flight, gliding high above the gliant's head and far out of reach.\n" +
                    "Ahead of you you see a light that may very well lead to your freedom. To your left you see the tunnel that leads to the room where you were held captive and where Red may still be imprisoned. Where do you fly?\n" +
                    "\n" +
                    "1. To Freedom!\n" +
                    "2. To rescue Red!\n" +
                    "3. Check Energy");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                switch(input)
                {
                    case 1:
                        //refactor this
                        adventureRepo.DecreaseEnergy();
                        adventureRepo.DecreaseEnergy();

                            TheBeast();
                        break;
                    case 2:

                            //add WriteLine here
                            RedRescue();
                        
                        break;
                    case 3:
                        Energy();
                        break;
                    default:
                        break;
                }
            }
        }

        private void FlyForFreedom()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You fly as hard and fast as you can, frantically seeking an exit before your captor gathers his senses and makes chase. As you fly into a large cavern you realize something is wrong... you can feel the spell wearing off. Your energy must have been lower than you realized. Knowing your wings will turn back to arms at any moment you dive towards the ground... no point in escaping a murderous giant only to die by your own magic! The spell wears off just as you reach the ground, tumbling gracelessly across the rocks on the cavern floor; human again. Coughing and gasping you stand up to get your bearings. Laying right in front of you, blinking its eyes and yawning as it wakes, is the largest beast you have ever seen. Your crash must have woken it. You might have described it as a wolf, but it is far larger than any wolf, with its back reaching your own height. He opens his eyes and the two of you lock eyes. You both freeze.\n" +
                    "\n" +
                    "1. Attack before the Beast can attack you!\n" +
                    "2. Tame the Beast.\n" +
                    "3. Check Energy");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                switch (input)
                {
                    case 1:
                        adventureRepo.DecreaseEnergy();
                        adventureRepo.DecreaseEnergy();
                        AttackBeast();

                        break;
                    case 2:
                        adventureRepo.DecreaseEnergy();
                        adventureRepo.DecreaseEnergy();
                        TameBeast();

                        break;
                    case 3:
                        Energy();
                        break;
                    default:
                        break;
                }
            }
        }

        private void EndGame()
        {
            Console.Clear();
            Console.WriteLine("'Look's like someone's sleepy,' your father chuckles as he picks you up. Craddling you in his arms he carries you back into the house. He scratches the family dog behind the ears as passes through the living room. As he walks through the kitchen he sighs at the sight of the butter knife still sticking out of the open jelly jar. 'I'll have to clean up the kitchen once you're asleep.' He carries you back to your room and closes the door, leaving it open just a crack and letting a beam of light pass into the room. You can barely keep your eyes open as he lowers you back into your crib. Reaching over the high bars nestles your favorite stuffed animal, a red panda, into the crib next to you and whispers, 'Rest well, my brave, little dragon! We'll have all sorts of new adventures tomorrow.'\n" +
                "\n" +
                "THE END");
            Console.ReadLine();
        }

        private void Energy()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Your current Energy is: { adventureRepo.CheckEnergy() }");
                Console.ReadLine();
                break;
            }
        }
    }
}
