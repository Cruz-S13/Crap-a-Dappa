# Crap-a-Dappa - CSC 205 Final Project

Hello and thank you for taking interest in my C# project! The purpose of this project is to highlight my skills using C# while presenting a casino game called 'Craps.' This program not only allow you to view how a game of Craps might turn out, but you can choose how many times the game will be played, and you will also receive statistics on wins per round.  

The basic rules of Craps are as follows (Detailed version of Craps can be found here: [How to Play Craps](https://www.youtube.com/watch?v=ItZTcnEg1sA)):

A player is given a pair of dice to roll against the back wall. 
1. If a player rolls a 7 or 11 on their first roll, it's an automatic win!
2. If a player rolls a 2 (Snake Eyes), 3 (Trey), or 12 (Boxcars) on their first roll, it's an automatic loss :(.
3. If any other dice sums are rolled (4, 5, 6, 8, 9 or 10), these are known as your 'Point' numbers. The player would continue to roll the dice until they either roll the point number again, or 7.  

There are two ways in which you can execute my code, either downloading the files and running it using an IDE of your choice, or you can navigate to the .exe file, located in '[file location]\Crap-A-Dappa\Crap-A-Dappa\bin\Debug\netcoreapp3.1\Crap-A-Dappa.exe'. For this demonstration, I will be executing the file locally.  

By default, the number of rolls that will be played is 5k. If you would like to roll a lesser number of times after you download the program from my repository, navigate to the following file, '[file location]\Crap-A-Dappa\Crap-A-Dappa\CrapsGame.cs'. Open the file in your favorite editing software and scroll down to line #31, then edit the number of times you would like to roll. Save the file and proceed to the next step.  

Navigate to '[file location]\Crap-A-Dappa\Crap-A-Dappa\bin\Debug\netcoreapp3.1\Crap-A-Dappa.exe' and double-click the .exe file. A console window will open up and display the following: Number of games played (depending on your environment, you may only see the last 10 or so games played), and the statistics of the games played. You will see how many wins per round, percentage of chances where you might win, and the average length of a craps game.  

This program consists of the 'Main' method and 3 other classes- CrapsGame, RollDice, and Statistics classes.

[insert Main graphics here.]

The 'CrapsGame' class consists of 2 enum data types and 5 methods, of which are the backbone of the program. This class utilizes the enums to either name special sums of the dice rolled, or contains the status of the game(s) until you are no longer in play. Switches are also used within this class to either evaluate the dice rolls where players will either win or lose on the first roll, or continue playing up to the desired amount of rolls.  

[insert CrapsGame graphics here.]

The 'RollDice' class is used to define the variables Die 1 and Die 2; additionally to call out the method 'DiceRoll' to give each the variables random numbers of the integers 1-6. The player doesn't see what each individual die rolls, but a sum of the two dice.  

[insert RollDice graphics here.]

The 'Statistics' class is uses calculations to show players the probability of winning, average length of games played, and wins per round via 4 different methods.

[insert Statistics graphics here.]
