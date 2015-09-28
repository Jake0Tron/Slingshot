using UnityEngine;
using System.Collections;

public class MultitouchHandler : MonoBehaviour {

    PlayerController player;
    public int touch;


	// Use this for initialization
	void Start () {
        this.player = FindObjectOfType<PlayerController>();
        this.touch = -1;
	}
	
	// Update is called once per frame
	void Update () {
        Touch to = Input.GetTouch(0);

        Touch[] touches = Input.touches;

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (touches[i].phase == TouchPhase.Began)
            {
                
            }
            
            

            // clear on release
            if (touches[i].phase == TouchPhase.Ended )
            {
                
            }
        }
	}
}
