using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Initialize health for the hero and the monster
        int heroHealth = 10;
        int monsterHealth = 10;

        // Create a Random object to generate attack values
        // The Random.Next(minValue, maxValue) method returns a random integer
        // that is greater than or equal to minValue and less than maxValue.
        // So, for values between 1 and 10 (inclusive), we use (1, 11).
        Random dice = new Random();

        Console.WriteLine("Battle Start!");
        Console.WriteLine("--------------------");

        // The game loop continues as long as both hero and monster have health greater than 0.
        // Using a do-while loop ensures at least one round of attack occurs.
        do
        {
            // --- Hero's Turn ---
            // Generate a random attack value for the hero (between 1 and 10)
            int heroAttack = dice.Next(1, 11);
            // Subtract the hero's attack from the monster's health
            monsterHealth -= heroAttack;

            // Print the damage dealt and the monster's remaining health
            Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

            // Check if the monster's health has dropped to 0 or less
            // If the monster dies, the battle ends and the hero wins.
            if (monsterHealth <= 0)
            {
                break; // Exit the loop as the monster is defeated
            }

            // --- Monster's Turn (only if monster is still alive) ---
            // Generate a random attack value for the monster (between 1 and 10)
            int monsterAttack = dice.Next(1, 11);
            // Subtract the monster's attack from the hero's health
            heroHealth -= monsterAttack;

            // Print the damage dealt and the hero's remaining health
            Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

            // Check if the hero's health has dropped to 0 or less
            // If the hero dies, the battle ends and the monster wins.
            if (heroHealth <= 0)
            {
                break; // Exit the loop as the hero is defeated
            }

            Console.WriteLine("--------------------"); // Separator for turns
        } while (heroHealth > 0 && monsterHealth > 0); // Loop condition: continue if both are still alive

        Console.WriteLine("--------------------");
        // Determine and print the winner after the battle loop ends
        if (heroHealth <= 0)
        {
            Console.WriteLine("Monster wins!");
        }
        else
        {
            Console.WriteLine("Hero wins!");
        }
    }
}
