using System;
using System.Collections.Generic;

bool repeatAgain = true;
// stores whether user loses, wins or draws
int wins = 0;
int losses = 0;
int draws = 0;

while(repeatAgain) 
{


//Start by randomising computer's choice 
Random randomNumber = new Random();

int computerChoice = randomNumber.Next(1, 4);

//Sets up a empty string to store move each time
string computerMove = "";

// set up switch choice so that each number input will produce either rock, paper, scissors

switch (computerChoice)
{
    case 1:
        computerMove = "ROCK";
        break;
    case 2:
        computerMove = "PAPER";
        break;
    case 3:
        computerMove = "SCISSORS";
        break;
}


//set up a list of validChoices 
string[] validChoices = new string[] { "ROCK", "PAPER", "SCISSORS" };

//empty string choice
string userChoice;
//Track if the user has input the wrong choice
bool firstAttempt = true;

//user a do while loop to make sure the user is alwasy asked at the start
do
{
    //gives warning after first try
    if (!firstAttempt)
    {
        Console.WriteLine("Invalid input! Please enter 'rock', 'paper', or 'scissors'.");
    }
    Console.WriteLine("Choice your weapon: Rock, Paper or Scissors? ");

    userChoice = Console.ReadLine().ToUpper();

    firstAttempt = false;
} while (!validChoices.Contains(userChoice));

// Now to compare both the user and the computer move to check to see who is the winner with their choices

//if player choices ROCK
if (userChoice == "ROCK")
{

    if (computerMove == "ROCK")
    {
        draws++;
    }
    else if (computerMove == "PAPER")
    {
        losses++;
    }
    else if (computerMove == "SCISSORS")
    {
        wins++;
    }
}
//if player choices paper
if(userChoice == "PAPER")
{
     if (computerMove == "ROCK")
    {
        wins++;
    }
    else if (computerMove == "PAPER")
    {
        draws++;
    }
    else if (computerMove == "SCISSORS")
    {
        losses++;
    }
}
//if player choices scissors
if(userChoice == "SCISSORS"){
     if (computerMove == "ROCK")
    {
        losses++;
    }
    else if (computerMove == "PAPER")
    {
        wins++;
    }
    else if (computerMove == "SCISSORS")
    {
        draws++;
    }
}

//show outcome and score so far
Console.WriteLine($"\nYou chose: {userChoice}");
Console.WriteLine($"Computer chose: {computerMove}");

if (wins > 0)
{
    Console.WriteLine("🎉 You win this round!");
}
else if (losses > 0)
{
    Console.WriteLine("💀 You lose this round!");
}
else
{
    Console.WriteLine("🤝 It's a draw!");
}


Console.WriteLine("Would you like to play again?(y/n)");
string playAgain = "";

do
{
    playAgain = Console.ReadLine().ToLower();

    // Check for invalid input and give a warning
    if (playAgain != "y" && playAgain != "n")
    {
        Console.WriteLine("Invalid input! Please enter 'y' to play again or 'n' to quit.");
    }

} while (playAgain != "y" && playAgain != "n");


if (playAgain == "y"){
    repeatAgain = true;
} else if (playAgain == "n"){
    repeatAgain = false;
}
};
// Show the score
Console.WriteLine($"\nFinal Score: Wins - {wins}, Losses - {losses}, Draws - {draws}");

Console.WriteLine("Thank you for playing!!");