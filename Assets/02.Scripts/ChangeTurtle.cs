using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTurtle : MonoBehaviour
{

    public GameObject[] Object;
    Quaternion qRotation = Quaternion.Euler(-90f, 0f, 0f);


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        // GameObject Object.Instantiate<GameObject>(GameObject original, Vector3 position, Quaternion rotation);
    }

    public void TurtleQ()
    {
    GameObject delTurtle1 = GameObject.FindGameObjectWithTag("T1");
    GameObject delTurtle2 = GameObject.FindGameObjectWithTag("T2");
    GameObject delTurtle3 = GameObject.FindGameObjectWithTag("T3");
    GameObject delTurtle4 = GameObject.FindGameObjectWithTag("T4");
        Instantiate(Object[0], transform.position, qRotation);
        Destroy(delTurtle2);
        Destroy(delTurtle3);
        Destroy(delTurtle4);
    }

    public void TurtleW()
    {
    GameObject delTurtle1 = GameObject.FindGameObjectWithTag("T1");
    GameObject delTurtle2 = GameObject.FindGameObjectWithTag("T2");
    GameObject delTurtle3 = GameObject.FindGameObjectWithTag("T3");
    GameObject delTurtle4 = GameObject.FindGameObjectWithTag("T4");
        Instantiate(Object[1], transform.position, qRotation);
        Destroy(delTurtle1);
        Destroy(delTurtle3);
        Destroy(delTurtle4);
    }
    public void TurtleE()
    {
    GameObject delTurtle1 = GameObject.FindGameObjectWithTag("T1");
    GameObject delTurtle2 = GameObject.FindGameObjectWithTag("T2");
    GameObject delTurtle3 = GameObject.FindGameObjectWithTag("T3");
    GameObject delTurtle4 = GameObject.FindGameObjectWithTag("T4");
        Instantiate(Object[2], transform.position, qRotation);
        Destroy(delTurtle1);
        Destroy(delTurtle2);
        Destroy(delTurtle4);
    }
    public void TurtleR()
    {
    GameObject delTurtle1 = GameObject.FindGameObjectWithTag("T1");
    GameObject delTurtle2 = GameObject.FindGameObjectWithTag("T2");
    GameObject delTurtle3 = GameObject.FindGameObjectWithTag("T3");
    GameObject delTurtle4 = GameObject.FindGameObjectWithTag("T4");
        Instantiate(Object[3], transform.position, qRotation);
        Destroy(delTurtle1);
        Destroy(delTurtle2);
        Destroy(delTurtle3);
    }
}
