//make sure to add comments to any code changed
var levelToLoad : String;
var beep : AudioClip;
var QuitButton : boolean = false;

function OnMouseEnter() {
	renderer.material.color = Color.red;
}
 function OnMouseUp(){

     if(QuitButton){
         Application.Quit();
     }
     else{
         Application.LoadLevel(levelToLoad);
     }
 }
function OnMouseExit() {
	renderer.material.color = Color.white;
}

