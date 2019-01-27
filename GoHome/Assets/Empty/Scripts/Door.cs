using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private int score = GameObject.Find("Player").GetComponent<PlayerManager>()._playerData.blood;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" )
        {

            //GameObject.Find("GameManager").Instance.ChangeScene(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        print(GameObject.Find("Player").GetComponent<PlayerManager>()._playerData.blood);
    }
}
