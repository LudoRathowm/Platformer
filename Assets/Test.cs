using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	
	private KeyCombo falconPunch= new KeyCombo(new string[] {"down", "right","up"});
	private KeyCombo falconKick= new KeyCombo(new string[] {"down", "right","Fire1"});
	private KeyCombo topblock = new KeyCombo (new string[] {"BackHigh", "up", "BackHigh"});
	void Update () {
		if (falconPunch.Check())
		{
			// do the falcon punch
			Debug.Log("PUNCH"); 
		}		
		if (falconKick.Check())
		{
			// do the falcon punch
			Debug.Log("KICK"); 
		}
		if (topblock.Check())
		{
			// do the Top block
			Debug.Log("TOPBLOCK"); 
		}
	}
}