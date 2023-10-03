using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public bool CheckState()
    {
        bool check = false;

        for(int i = 0; i < gameObjects.Count; i++)
        {
            if (gameObjects[i].GetComponent<Block>().state == State.Green)
            {
                check = true;
            }
            else
            {
                check = false;
                return check;
            }
        }

        return check;
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
