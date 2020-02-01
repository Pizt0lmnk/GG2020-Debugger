# Debugger
2D Game 

## Topics
- Science Fiction
- Post Apocalyptic
- Story driven

## Story

### Prehistory
Humans have tried to create an AI named HOPE. This AI was designed to save the World from climate change but HOPE turned and started to destroy nature. Dr. John McCarthy, one of the main creators of HOPE, developed a second but not yet finished AI called J1mb0x. J1mb0x was created as a countermeasure to HOPE. Before Dr. McCarthy died, he hid J1mb0x at a secret place. For decades humans were searching for J1mb0x, with no luck. The faith to save the world as we know it is almost lost, just as human kind is.

### Main Storyline
Its the year 2500 and human kind is almost extinct. HOPE, an almost omnipotent AI, destroys nature and life to gather more and more resources to expand its technical empire. Meanwhile HOPEs highly intelligent androids are hunting down the remaining organical creatures.

A small enclave of human also known as the rebels are trying to survive in this cruel highly futuristic world. Lead by General Tulkin they are on a hunt for a last hope: J1mb0x an AI hidden by its creator, built to bring back balance between technical progress and Earth. But as the decades go by people are starting to loose their faith that J1mb0x exists.  

Alexei a Survivor with a dark past receives an unknown message. It contains a sentence that says "It’s worth fighting for." and some coordinates "51.1739726374 -1.82237671048". Against the will of those that love him, he packs his stuff and leaves. A last glance of this last hope everyone had. Knowing the great danger that lies upon him and his small chance of success, he is still willing to take the risk. All just to save human kind and his unborn child. 

## Characters
Position | Role | Name | Traits
------------ | ------------- |------------ | -------------
Main Character | Player | Alexei | Mainly good; Want's to save earth and especially humans; Has a dark past but wants to be better in the future.
Main Character | Player | J1mb0x | Pure good; Naive; Only interested in bringing back the balance between nature and technology
Side Character | Enemy | H0PE | Evil; Wants to create a fully robotic earth without any organic live
Side Character | AI-Creator | Dr. John McCarthy | Genius; Paranoid/kinda crazy
Side-Main Character | General of human rebellion | General Tulkin | Anti technology; Has lost faith that J1mb0x can save them; Pessimist; Family was killed by HOPEs Androids
Side-Main Character | Wife of Alexei | x | Deeply in love with Alexei; Optimistic and Supportive; Scared from his transformation; Pregnant
Side-Main Character | Best friend of Alexei | x | Not that smart; Funny; Thinks J1mb0x is neat.

### Main Character

#### Look
- Beard
- Wears a robe
- Right arm and eye are robotic
- Legs are robotic

#### Abilities

##### Movement
Key | Action
------------ | -------------
W | Jump
A | Run left
S | Duck
D | Run right

##### Combat
Key | Action
------------ | -------------
Space | Fire selected ability
1-9 | Change abilities 
1 | Bits
2 | Fire

## Enemies

Type | Abilities | Weaknesses | Strengths
------------ | ------------- |------------ | -------------
Android | Firearm to shoot bullets | Slow; Increased bit damage | Very agile; Immune to fire damage; Player needs to duck to avoid gunshot damage.
Mutant | Player | Weak; Increased fire damage | Fast; Immune to bit damage

## World

### Inspriation
The linked artworks belong to their respective owners
https://wallpaperaccess.com/full/1810868.jpg
https://images.hdpictures.me/backgrounds/602x339-science-fiction-city-hd-wallpaper.jpg
https://i.imgur.com/PMv5IZq.png

### Levels

#### Tutorial
Learn Basics 

##### Level design (Learning focused)
1. You start autorunning the game pauses a text appears above the players head "Move | A <-> D"
2. You run to the right the game continues an event is triggered Androids spawn; You have to run away
3. A mechanical crate appears the game pauses and a text appears "Jump | Space"; You jump over the box and continue running away;
4. An Event triggers the Androids start to shoot;
5. Game pauses text appears "Duck | S"; You dodge the bullet
6. You run into Stonehenge; Androids are gettin' eliminated.
7. An elevator lowers the player into the ground

##### Script
```
[START]

Alexei runs away from a group of androids

    Alexei:
    **heavy breathing** I'm almost there...

Alexei is getting closer to his destination, and sees something strange

    Alexei:
    What's that?

Alexei gets inside a ring of stones (Stonehenge)
All of a sudden the androids are getting deactivated

    Alexei:
    What the heck is going on?!

The floor starts to tremble and lowers itself.
The Screen fades to black.

[END]
```

#### Intro

##### Level design (Story focused)
1. The player starts seeing Alexei inside an elevator lowering
2. The Elevator opens and the player is walking in a room that seems to be a lab
3. There is all sorts of technical equipment and in the middle of the room a light beam on a podest in front of it a terminal.
4. The player walks to the terminal above his head a text appears "Interact | F"
5. You get a closeup to the Terminal with a hint "Type 'help' to list all commands"
6. The player types help and the list of commands appears "activate J1-mb0-x, {FURTER_COMMANDS}"
7. As soon the player enters "activate J1-mb0-x" you hear a loud mechanical noise and someone talking
8. Alexei talks to the J1mb0x
9. The player moves into the light beam and the transformation process begins
10. Alexei loses continuousness

##### Script
```
Alexei is inside an elevator 

    Alexei:
    [ ... ]
```
#### Act 1
Return to your the human enclave to talk with General {HUMAN_LEADER_NAME}.

##### Level design (Combat focused)

##### Script
```
Alexei and J1mb0x 

    Alexei:
    I feel so powerful
```
#### Act 2

##### Level design (Riddle focused)

##### Script
```

```
#### Act 3

##### Level design (Boss focused)

##### Script
```

```
## Mechanics