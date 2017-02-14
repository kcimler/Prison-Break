using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom, corridor_0,
						 stairs_0, floor, closet_door, corridor_1, stairs_1, in_closet, corridor_2, stairs_2,
						 corridor_3, courtyard_0, game_over_1, game_over_2,};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell)				{cell();} 
		else if (myState == States.sheets_0)	{sheets_0();} 
		else if (myState == States.mirror)		{mirror();} 
		else if (myState == States.lock_0)		{lock_0();} 
		else if (myState == States.cell_mirror) {cell_mirror();} 
		else if (myState == States.sheets_1) 	{sheets_1();} 
		else if (myState == States.lock_1)		{lock_1();} 
		else if (myState == States.freedom)		{freedom();}
		else if (myState == States.corridor_0)  {corridor_0();}
		else if (myState == States.stairs_0)	{stairs_0();}
		else if (myState == States.closet_door)	{closet_door();}
		else if (myState == States.floor)		{floor();}
		else if (myState == States.corridor_1)	{corridor_1();}
		else if (myState == States.stairs_1)	{stairs_1();}
		else if (myState == States.in_closet)	{in_closet();}
		else if (myState == States.corridor_2)	{corridor_2();}
		else if (myState == States.stairs_2)	{stairs_2();}
		else if (myState == States.corridor_3)	{corridor_3();}
		else if (myState == States.courtyard_0)	{courtyard_0();}
		else if (myState == States.game_over_1)	{game_over_1();}
		else if (myState == States.game_over_2)	{game_over_2();}
	}
	
	#region State Handler Methods
	void cell () {
		text.text = "You're eyes slowly open. Your head is throbbing. You have no memory of what has happened. " +
					"However, as you gathering your bearings, you see you are inside a pretty barren prison " +
					"cell. As you stand up to look around, you notice your cell contains a bed and a mirror. " +
					"Directly in front of you, you notice the large iron doors holding you captive. Panicked, " +
					"you quickly try and find a way to escape. What do you do?\n\n" +
					"Press S to view your bed Sheets, M to view Mirror, and L to view the Locked Door.";
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_0;} 
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror;} 
		else if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_0;}
	}
	
	void sheets_0 () {
		text.text = "Geez. This bed is actually awful. From the odor all the way to the garish color, " +
					"you'd be better off requesting solitary confinement.\n\n" +
					
					"Press R to Return to your cell.";
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
	}
	
	void mirror () {
		text.text = "You see yourself in the reflection of the mirror...and you probably wished " +
					"you hadn't. Not gonna lie, you've seen better days. However, you realize this mirror is " +
					"loose, and can be taken off the wall.\n\n" +
				
					"Press R to Return to your cell, or T to Take the mirror.";
		if 		(Input.GetKeyDown(KeyCode.R)) 	{myState = States.cell;} 
		else if (Input.GetKeyDown(KeyCode.T))	{myState = States.cell_mirror;}
	}
	
	void lock_0 () {
		text.text = "You apporach the door. You pull and try to open it, but its locked...Which is to be expected.\n\n" +
				
					"Press R to Return to your cell.";
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
	}
	
	void cell_mirror () {
		text.text = "You couldnt tell by looking at it, but damn that mirror is heavy! Not only that, you've " +
					"just made your cell even that more depressing by taking down your one decoration. And on " +
					"top of all of that, you STILL need to escape!\n\n" +
					
					"Press S to view your bed Sheets, or L to view the Locked door." ;
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_1;} 
		else if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_1;}
	}
	
	void sheets_1 () {
		text.text = "...I mean, C'mon. You're honestly better off sleeping on the floor then on this " +
					"deathtrap. Whoever decided this bed was a good idea should be the one locked in here...\n\n" +
				
					"Press R to Return to your cell.";
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.cell_mirror;}
	}
	
	void lock_1 () {
		text.text = "You apporach the door. You try to open it, but its locked...Which is to be expected. " +
					"However, you do have the mirror with you. You could try and smash it against the door in " +
					"hopes it will do something, but it might just break the mirror and you're now even more " +
					"screwed.\n\n" +
			
					"Press R to Return to your cell, or S to Smash the mirror into the door.";
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.cell_mirror;} 
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.freedom;}
	}
	
	void freedom () {
		text.text = "BAM! Just like that the door flung open! And thats when it hit you... " +
					"the door was a push, not a pull! The mirror, unfortunately, did not survive " +
					"the blow. You drop the remains of that mirror to the ground as you step out into " +
					"the corridor.\n\n" +
					"Press C to Continue into the corridor";
					
		if 		(Input.GetKeyDown(KeyCode.C))	{myState = States.corridor_0;}
	}
	
	void corridor_0 () {
		text.text = "You quickly survey the corridor. Off to your left, you see a staircase leading up a floor. " +
					"Off to your right, you see a door with a handwritten note labeled closet. The floor " +
					"is litterd with junk galore...which explains the putrid smell.\n\n" +
					"Press S to view the Staircase, F to view the Floor, or C to view the Closet.";
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.F))	{myState = States.floor;}
		else if (Input.GetKeyDown(KeyCode.C))	{myState = States.closet_door;}
	}
	
	void stairs_0 () {
		text.text = "As you approach the stairs, you can hear the mumbling of voices above. Its hard to " +
					"make out what they're saying, but you definetly heard the word watermellon at one point. " +
					"You're currently unarmed and out manned, so going upstairs could be risky.\n\n" +
					"Press U to go Upstairs or R to Return to the corridor.";
		
		if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.game_over_1;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_0;}
	}
	
	void game_over_1 () {
		text.text = "You proceed upstairs, to enter a guard room, where apprently the entire prison " +
					"staff is celebrating a birthday! Without thinking, you start singing along to the birthday " +
					"song. As soon as you join the four-part harmony, everyone stops and stairs at you. " +
					"Before you can utter a word, they all pull out their guns and shoot you on the spot.\n\n" +
					"GAME OVER\n\n" +
					"Press P to play again." ;
		
		if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.cell;}
	}
	
	void closet_door () {
		text.text = "You move towards the closet door, however its locked. (And yes, you tried both " +
					"pushing and pulling this time.) The lock seems pretty shabby and could be picked open " +
					"if you found a pick of some sort.\n\n" +
					"Press R to Return to the corridor.";
		
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_0;}
	}
	
	void floor() {
		text.text = "You scan the floor around you. Apart from the blood and s*** stains, there isnt much " +
					"to look at. However, you notice a couple of hairclips scattered around the floor. " +
					"Might not be a bad idea to take one, just in case!\n\n" +
					"Press T to Take a hairclip, R to Return to Corridor.";
		
		if 		(Input.GetKeyDown(KeyCode.T))	{myState = States.corridor_1;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_0;}
	}
	
	void corridor_1() {
		text.text = "Returning back to the corridor with a hairclip in hand, it feels good knowing " +
					"you've done your civic duty and help picked up some litter. If this was a 'Sims' game " +
					"your happiness would be increasing due to the cleansliness of the corridor. " +
					"Now that you've gotten the hairclip, you could try and pick the closet door!\n\n" +
					"Press S to view the Stairs, or P to Pick the lock.";
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_1;}
		else if (Input.GetKeyDown(KeyCode.P)) 	{myState = States.in_closet;}
	}
	
	void stairs_1 () {
		text.text = "As you approach the stairs, you can hear the mumbling of voices above. Its hard to " +
					"make out what they're saying, but you definetly heard the word watermellon at one point. " +
					"You still have your hairclip in hand, but it might still be a little ambitious " +
					"to walk upstairs.\n\n" +
					"Press U to go Upstairs, or press R to Return to the corridor.";
		
		if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.game_over_2;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_1;}
	}
	
	void game_over_2 () {
		text.text = "You proceed upstairs, to enter a guard room, where apprently the entire prison " +
					"staff is celebrating a birthday! Without thinking, you start singing along to the birthday " +
					"song. As soon as you join the four-part harmony, everyone stops and stairs at you. " +
					"In a panic, you draw your hairclip in an attempt to arm yourself. In response, the guards draw " +
					"Their side arms and unload a few rounds at you. As the old saying goes, " + "dont bring a " +
					"hairclip to a gun fight!" + "\n\n" +
					"GAME OVER\n\n" +
					"Press P to play again." ;
		
		if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.cell;}
	}
	
	void in_closet () {
		text.text = "You successfuly pick the lock and enter the closet. Inside, you see a bunch of cleaning " +
					"supplies along with a spare janitors outfit. Better yet, that outfit is just your size! Wow! " +
					"What a coincidence! What do you do?\n\n" +
					"Press D to Dress yourself in the janitors outfit, or R to Return to the corridor.";
		
		if 		(Input.GetKeyDown(KeyCode.D))	{myState = States.corridor_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.corridor_2;}
	}
	
	void corridor_2() {
		text.text = "It's not so much fun just going back and forth like this isnt it. " +
					"Not only are you wasting time, you are also getting sweaty. Ew...\n\n" +
					"Press B to go Back into the closet, or press S to view the stairs." ;
		
		if 		(Input.GetKeyDown(KeyCode.S))	{myState = States.stairs_2;}
		else if (Input.GetKeyDown(KeyCode.B)) 	{myState = States.in_closet;}
	}
	
	void stairs_2 () {
		text.text = "As you approach the stairs, you can hear the mumbling of voices above. Its hard to " +
					"make out what they're saying, but you definetly heard the word watermellon at one point. " +
					"You still have your hairclip in hand, but it might still be a little ambitious " +
					"to walk upstairs. It would be safer if you could find a disguise of some sort. " +
					"Hmm...I wonder there a convienent dsguise would be located...\n\n" +
					"Press U to go Upstairs, or press R to Return to the corridor.";
		
		if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.game_over_2;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.corridor_2;}
	}
	
	void corridor_3() {
		text.text = "Decked out in your new janitors outfit, you stride back into the corridor filled " +
					"with a sense of determination and pride. Maybe being a janitor was your true calling " +
					"after all. Although, while you think it looks good, it's hard to guage " +
					"whether or not the disguise is working. (Wouldve been nice if you had the mirror still...) " +
					"Might be risky walking around in a poorly, put-together disguise, but its you're call.\n\n" +
					"Press U to go Upstairs, or press R to Remove disguise back in the closet." ;
		
		if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.courtyard_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 	{myState = States.in_closet;}
	}
	
	
	void courtyard_0() {
		text.text = "Being the bold person you are, you decide to roll the dice and hope the disguise pays off. " +
					"Luckily for you, the entire prison staff was celebrating a birthday upstairs! Being able to blend " +
					"in with the crowd, you were able to join in on the killer four part harmony to the birthday song, " +
					"highfive a couple of people, and grab a plate of cake as you walk out the front door into the courtyard.\n\n" +
					"CONGRATS! You successfully escaped prison!\n\n" +
					"Press P to Play again." ;
		
		if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.cell;}
	}
	#endregion
	
	
}