﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleformsResearch
{
    internal static class Util
    {
        public static T Clamp<T>(this T x, T min, T max) where T : IComparable<T> => Rage.MathHelper.Clamp(x, min, max);
        public static T Random<T>(this IEnumerable<T> from) => from.ElementAt(Rage.MathHelper.GetRandomInteger(0, from.Count() - 1));
        public static T[] EnumValues<T>() where T : Enum => Enum.GetValues(typeof(T)).Cast<T>().ToArray();

        public static Rage.Ped MainPlayer => Rage.Game.LocalPlayer.Character;

        public static readonly string[] Phrases = new string[100]
        {
            "The green tea and avocado smoothie turned out exactly as would be expected.",
            "She looked at the masterpiece hanging in the museum but all she could think is that her five-year-old could do better.",
            "I love bacon, beer, birds, and baboons.",
            "He was willing to find the depths of the rabbit hole in order to be with her.",
            "Green should have smelled more tranquil, but somehow it just tasted rotten.",
            "She advised him to come back at once.",
            "He was sure the Devil created red sparkly glitter.",
            "He wasn't bitter that she had moved on but from the radish.",
            "Improve your goldfish's physical fitness by getting him a bicycle.",
            "There have been days when I wished to be separated from my body, but today wasn’t one of those days.",
            "He wondered if it could be called a beach if there was no sand.",
            "If I don’t like something, I’ll stay away from it.",
            "Sometimes I stare at a door or a wall and I wonder what is this reality, why am I alive, and what is this all about?",
            "This is a Japanese doll.",
            "Check back tomorrow; I will see if the book has arrived.",
            "He was the type of guy who liked Christmas lights on his house in the middle of July.",
            "To the surprise of everyone, the Rapture happened yesterday but it didn't quite go as expected.",
            "8% of 25 is the same as 25% of 8 and one of them is much easier to do in your head.",
            "His son quipped that power bars were nothing more than adult candy bars.",
            "The clouds formed beautiful animals in the sky that eventually created a tornado to wreak havoc.",
            "As time wore on, simple dog commands turned into full paragraphs explaining why the dog couldn’t do something.",
            "She always had an interesting perspective on why the world must be flat.",
            "I met an interesting turtle while the song on the radio blasted away.",
            "He excelled at firing people nicely.",
            "Lightning Paradise was the local hangout joint where the group usually ended up spending the night.",
            "She used her own hair in the soup to give it more flavor.",
            "His mind was blown that there was nothing in space except space itself.",
            "It was obvious she was hot, sweaty, and tired.",
            "There's an art to getting your way, and spitting olive pits across the table isn't it.",
            "After fighting off the alligator, Brian still had to face the anaconda.",
            "At that moment he wasn't listening to music, he was living an experience.",
            "Tomorrow will bring something new, so leave today as a memory.",
            "Pair your designer cowboy hat with scuba gear for a memorable occasion.",
            "The thick foliage and intertwined vines made the hike nearly impossible.",
            "Nobody questions who built the pyramids in Mexico.",
            "Car safety systems have come a long way, but he was out to prove they could be outsmarted.",
            "He invested some skill points in Charisma and Strength.",
            "I'm a great listener, really good with empathy vs sympathy and all that, but I hate people.",
            "Everybody should read Chaucer to improve their everyday vocabulary.",
            "He found rain fascinating yet unpleasant.",
            "Having no hair made him look even hairier.",
            "He knew it was going to be a bad day when he saw mountain lions roaming the streets.",
            "When I cook spaghetti, I like to boil it a few minutes past al dente so the noodles are super slippery.",
            "Peanuts don't grow on trees, but cashews do.",
            "As he waited for the shower to warm, he noticed that he could hear water change temperature.",
            "When he had to picnic on the beach, he purposely put sand in other people’s food.",
            "Had he known what was going to happen, he would have never stepped into the shower.",
            "Even with the snow falling outside, she felt it appropriate to wear her bikini.",
            "He kept telling himself that one day it would all somehow make sense.",
            "He hated that he loved what she hated about hate.",
            "I currently have 4 windows open up… and I don’t know why.",
            "She did a happy dance because all of the socks from the dryer matched.",
            "The external scars tell only part of the story.",
            "They called out her name time and again, but were met with nothing but silence.",
            "Nobody has encountered an explosive daisy and lived to tell the tale.",
            "She lived on Monkey Jungle Road and that seemed to explain all of her strangeness.",
            "He took one look at what was under the table and noped the hell out of there.",
            "She had the gift of being able to paint songs.",
            "For oil spots on the floor, nothing beats parking a motorbike in the lounge.",
            "The bees decided to have a mutiny against their queen.",
            "I am counting my calories, yet I really want dessert.",
            "Jeanne wished she has chosen the red button.",
            "The truth is that you pay for your lifestyle in hours.",
            "When nobody is around, the trees gossip about the people who have walked under them.",
            "There aren't enough towels in the world to stop the sewage flowing from his mouth.",
            "He strives to keep the best lawn in the neighborhood.",
            "Wisdom is easily acquired when hiding under the bed with a saucepan on your head.",
            "Check back tomorrow; I will see if the book has arrived.",
            "Pink horses galloped across the sea.",
            "25 years later, she still regretted that specific moment.",
            "He found the chocolate covered roaches quite tasty.",
            "He drank life before spitting it out.",
            "Mary realized if her calculator had a history, it would be more embarrassing than her computer browser history.",
            "She had convinced her kids that any mushroom found on the ground would kill them if they touched it.",
            "The Japanese yen for commerce is still well-known.",
            "Iron pyrite is the most foolish of all minerals.",
            "The toy brought back fond memories of being lost in the rain forest.",
            "The blinking lights of the antenna tower came into focus just as I heard a loud snap.",
            "He was an introvert that extroverts seemed to love.",
            "David proudly graduated from high school top of his class at age 97.",
            "The virus had powers none of us knew existed.",
            "The clouds formed beautiful animals in the sky that eventually created a tornado to wreak havoc.",
            "One small action would change her life, but whether it would be for better or for worse was yet to be determined.",
            "The door swung open to reveal pink giraffes and red elephants.",
            "Going from child, to childish, to childlike is only a matter of time.",
            "Even with the snow falling outside, she felt it appropriate to wear her bikini.",
            "Sometimes it is better to just walk away from things and go back to them later when you’re in a better frame of mind.",
            "The irony of the situation wasn't lost on anyone in the room.",
            "He realized there had been several deaths on this road, but his concern rose when he saw the exact number.",
            "I am my aunt's sister's daughter.",
            "Martha came to the conclusion that shake weights are a great gift for any occasion.",
            "Doris enjoyed tapping her nails on the table to annoy everyone.",
            "The lake is a long way from here.",
            "Lets all be unique together until we realise we are all the same.",
            "The lyrics of the song sounded like fingernails on a chalkboard.",
            "Smoky the Bear secretly started the fires.",
            "She had a habit of taking showers in lemonade.",
            "Be careful with that butter knife.",
            "Writing a list of random sentences is harder than I initially thought it would be.",
            "I caught my squirrel rustling through my gym bag.",
        };
    }
}
