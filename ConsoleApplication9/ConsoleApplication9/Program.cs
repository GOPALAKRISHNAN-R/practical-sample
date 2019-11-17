using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Simple c# program 
 * @author R.GOPALAKRISHNAN
 * @author gopalakrishnanr94@gmail.com
 * @author www.rgopalakrishnanmca.simplesite.com
 **/
 
namespace ConsoleApplication9
{
    
class GameScore
    {
string user;
int age;
public GameScore()
        {
user = "YuvanArul";
age = 23;
Console.WriteLine("Previous user {0} and he was {1} years old", user, age);
        }
public GameScore(string name, int age1)
        {
user = name;
age = age1;
Console.WriteLine("Current user {0} and he is {1} years old", user, age);
        }
    }
class Program
    {
static void Main(string[] args)
        {
GameScore gs = new GameScore(); 
GameScore gs1 = new GameScore("Chaithu", 21);
Console.ReadLine();
        }
    }
}

       
