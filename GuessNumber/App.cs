﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class App
    {
        readonly IAnimation animation;
        readonly IGame game;

        public App(IAnimation animation, IGame game)
        {
            this.animation = animation;
            this.game = game;
        }

        public void Run()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                game.Run();
                Console.WriteLine("Continue? Press any key to continue, N to exit:");
                var userWantsToContinue = Console.ReadLine();
                keepGoing = userWantsToContinue?.ToUpper() != "N";
            }
            animation.Run();
        }

    }

}
