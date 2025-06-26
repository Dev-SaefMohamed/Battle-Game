Main Idea of the Game Logic:
The core logic of this game is a turn-based combat simulation where two entities, 
a Hero and a Monster, engage in a fight by inflicting random damage upon each other until one's health drops to zero or below, 
determining the winner.

The program orchestrates a simple battle between a Hero and a Monster,
both starting with 10 health points. The game unfolds in a continuous loop:

Hero's Attack: The Hero always strikes first in each round,
dealing a random amount of damage (between 1 and 10) to the Monster.

Monster's Condition Check: After the Hero's attack, the game checks if the Monster is still alive. 
If its health is zero or less, the Monster is defeated, 
and the battle concludes with the Hero winning.

Monster's Counter-Attack: If the Monster survives the Hero's attack, 
it retaliates by dealing a random amount of damage (between 1 and 10) to the Hero.

Hero's Condition Check: Following the Monster's attack, the game checks if the Hero is still alive. 
If the Hero's health is zero or less, 
the Hero is defeated, and the battle concludes with the Monster winning.

Loop Continuation: If both the Hero and the Monster are still alive, 
the battle proceeds to the next round,
repeating the sequence of attacks.
