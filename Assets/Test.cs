using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	private Animator animator;
	private float blocktimer = 0.5f;
	private float blockduration = 0.5f;
	public bool isTopBlocking = false;
	private KeyCombo falconPunch= new KeyCombo(new string[] {"down", "right","up"});
	private KeyCombo falconKick= new KeyCombo(new string[] {"down", "right","Fire1"});
	private KeyCombo topblock = new KeyCombo (new string[] {"BackHigh"});
	void Awake (){
		animator = GetComponent<Animator>();

	}
	void Update () {
		if (blocktimer> 0)
			blocktimer -= Time.deltaTime;
		if (blocktimer < 0)
			blocktimer = 0;
		if (blocktimer == 0) {
			Debug.Log ("NOTBLOCKING");	
			isTopBlocking = false;
			blocktimer = blockduration;
				}


		if (falconPunch.Check())
		{
			// do the falcon punch
			Debug.Log("PUNCH"); 
		}		
		if (falconKick.Check())
		{
		
			Debug.Log("KICK"); 
		}
		if (topblock.Check())
		{ topBlock();
			}
	}

void	topBlock(){
		//Debug.Log ("Blocked high attack");
		animator.SetTrigger("topblock");
		isTopBlocking = true;

		//i'll make it so that you block attacks from enemies with y > your y or with top attack attribute,idk 

	}
}