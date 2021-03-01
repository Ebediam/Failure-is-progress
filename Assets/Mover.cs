using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public GameObject movingObject;
    public Transform startPosition;
    public Transform endPosition;
    public MoverData data;

    bool open = true;
   

    // Start is called before the first frame update
    void Start()
    {
        movingObject.transform.position = startPosition.position;

        data.startEvent += OnStart;
        data.endEvent += ResetMover;
        if (data.startsActive)
        {            
            StartCoroutine(StartToEnd());
        }
        
        
    }

    void OnStart()
    {
        StartCoroutine(StartToEnd());
    }

    IEnumerator StartToEnd()
    {
        yield return new WaitForSeconds(data.onInitialTime);
        while(Vector3.Distance(movingObject.transform.position, endPosition.position) > data.distanceThreshold)
        {
            movingObject.transform.position += (endPosition.position - movingObject.transform.position).normalized*data.goSpeed * Time.deltaTime;
            yield return null;
        }
        StartCoroutine(EndToStart());

    }

    IEnumerator EndToStart()
    {
        yield return new WaitForSeconds(data.onEndTime);
        while (Vector3.Distance(movingObject.transform.position, startPosition.position) > data.distanceThreshold)
        {
            movingObject.transform.position += (startPosition.position - movingObject.transform.position).normalized*data.returnSpeed * Time.deltaTime;
            yield return null;
        }
        StartCoroutine(StartToEnd());
    }


    void ResetMover()
    {
        StopAllCoroutines();
        movingObject.transform.position = startPosition.position;
    }
}
