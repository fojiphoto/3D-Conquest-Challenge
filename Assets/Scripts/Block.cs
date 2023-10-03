using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public GameObject greenObject;

    public GameObject redObject;

    public State state;

    private void Start()
    {
        state = State.Idle;
    }

    private void Update()
    {
        switch(state)
        {
            case State.Idle:

                greenObject.SetActive(false);
                redObject.SetActive(false);

                break;
            case State.Green:

                greenObject.SetActive(true);
                redObject.SetActive(false);

                break;
            case State.Red:

                greenObject.SetActive(false);
                redObject.SetActive(true);

                break;
        }
    }

    public void SetState(State stateVar)
    {
        state = stateVar;
    }

    private void OnMouseDown()
    {
        if (state == State.Green) return;

        Player.Instance.Shoot(transform);
    }
}
