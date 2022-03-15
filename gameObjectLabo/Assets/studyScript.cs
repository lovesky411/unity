using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Study!");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            float rnd = Random.Range(0.0f, 0.5f);
            this.transform.position = new Vector3 (0.0f, 0.0f, rnd);
        }

        if(Input.GetKeyDown(KeyCode.B)){
            float rnd = Random.Range(0.0f, 360.0f);
            this.transform.rotation = Quaternion.Euler(rnd, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(
                   new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(
                Vector3.back * 2.0f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.P)){
            GameObject go = GameObject.Find("Cube") as GameObject;
            go.transform.parent = this.transform;
        }

        if (Input.GetKey(KeyCode.N)){
            GameObject go = GameObject.Find("Cube") as GameObject;
            go.transform.parent = null;
        }

        if(Input.GetKey(KeyCode.G)){
            GameObject go = GameObject.Find("Cube") as GameObject;
            go.GetComponent<cubeScript>().bigsize();
        }
        
    }
}
