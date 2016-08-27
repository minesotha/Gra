using UnityEngine;
using System.Collections;

public class GoNextRoom : MonoBehaviour {


    GameObject nextRoom;

    void OnCollisionEnter2D(Collision2D coli)
    {
        if (coli.gameObject.tag == "goRight"|| coli.gameObject.tag == "goLeft")
        {
            nextRoom = coli.gameObject;
            nextRoom = nextRoom.GetComponent<goRoomGameObject>().getRoom();
            MoveCamera();
            MovePlayer();
        
        }
    }


    void MoveCamera()
    {
        Vector3 newPosition = nextRoom.transform.position;
        Camera.main.transform.position = new Vector3(newPosition.x, newPosition.y, -15);
    }

    void MovePlayer()
    {
        this.transform.position = nextRoom.transform.position;
    }

    void FixedUpdate()
    {

    }


}
