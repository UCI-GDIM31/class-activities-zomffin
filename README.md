# in-class-activities
## Devlogs
### W1
Hello World! 

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

### Week 2 Devlog
1. The color variables are floats because the range of the value is from 0.0 to 1.0. If we use int, it would be stuck as only 0 or 1. Floats can have decimal values, so we can use the full range. 
2. The bounce variable has to count, so it should be a number value. Strings can include numbers, but are normally words/sentences. A boolean is only true/false and won't be able to count the bounces. 
    A float could work, but because a count will always be a whole number (it's impossible for the ball to do half a bounce), an int is ideal. 
3. I didn't get any errors woopsie. 

### Week 3 Devlog
Table 6, Rhythm game prompt 
DidPlayerHitBeat() 
The paramter/input should be a key press and time it was pressed. 
The return type should be a boolean, since we're measuring if they did or didn't hit it (assuming there's no accuracy measuring). 

MonoBehaviour
1. The relationship between classes and components is similar to that of cooking recipes. Classes are like recipes, guidelines that components should follow. Components give those recipes to the GameObjects (kitchen) which get cooked when you run the game. 
    Method are the steps to the recipe while member variables are the ingredients. Sometimes you might have to grab an ingredient from another part of the kitchen (a different GameObject/Script). 
2. The multiplier keeps multiplying, so it's exponential. If it's bounced 5 times and hit the threshold 3 times, then it's color modifier has been multiplied 1.5^3. ^

### Week 4 Devlog
Table 7

Line 5 is declaring a member variable. It's a float called _moveSpeed, probably related... to movement speed. It's a serialized field, so it can be edited from the inspector pane. 

Line 22 is making a calculation thats storing into a new variable called translation. It's using a method to check if the player is pressing the button related to vertical (the paramater calls for the name of the input, so "Vertical" here) movement, then adjusting that by the stored _moveSpeed and the amount of time passed. 

Line 25 is taking the calculation from line 22, then applying it with a method to the transform component of the GameObject. The method paramters call for x, y, and/or z values. We change the third value, so it's moving the object on the z-axis. 


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 