using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    PlayerController player;
    public float yOffset;

	// Use this for initialization
	void Start () {
        this.player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 newPos = new Vector2(player.transform.position.x, player.transform.position.y + yOffset);

        this.transform.position = newPos;
	}
}
