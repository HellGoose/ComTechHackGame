/* Copyright (c) 2007-2012 Technicat, LLC */
/* Type GUIText */

static var word:String="";

// similar to the Input.inputString example in the Unity Script Reference
// except here we place the current text in the GUIText of this game object
// and the complete word in a static variable, where it will be checked by all the flying words
function Update () {
  for (var c : char in Input.inputString) {
    if (c == "\b"[0] && GetComponent.<GUIText>().text.Length != 0) {
      GetComponent.<GUIText>().text = GetComponent.<GUIText>().text.Substring(0, GetComponent.<GUIText>().text.Length - 1);
    } else if (c == "\n"[0] || c=="\r"[0]) {
    	word = GetComponent.<GUIText>().text;
    	GetComponent.<GUIText>().text = "";
    } else {
      GetComponent.<GUIText>().text += c;
    }
  }  
}
