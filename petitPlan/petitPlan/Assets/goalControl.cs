using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onCollisionStay(Collision other){
        this.is_collided = true;
    }

    void OnGUI(){
        if(is_collided){
            GUI.Label(new Rect(Screen.width/2, 80, 100, 20), "성공");
        }
    }
}
