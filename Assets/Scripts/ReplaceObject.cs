using UnityEngine;

public class ReplaceObject : MonoBehaviour
{
    public GameObject[] objects; 

    private void Start()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }

    public void ShowObject(int index)
    {
        if (index >= 0 && index < objects.Length)
        {
            objects[index].SetActive(true);
            objects[index].transform.position = transform.position;
        }
    }

    public void HideObject()
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }
}
