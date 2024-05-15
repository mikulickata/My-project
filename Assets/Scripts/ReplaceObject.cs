using UnityEngine;

public class ReplaceObject : MonoBehaviour
{
    public GameObject[] objects; // Niz objekata koji æe biti upravljani
    public Vector3 offsetFromParent = Vector3.zero; // Pomak od roditeljskog GameObjecta

    private void Start()
    {
        // Na poèetku iskljuèujemo sve objekte
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }

    // Metoda za prikazivanje odreğenog objekta
    public void ShowObject(int index)
    {

        // Prikazujemo samo odabrani objekt ako je index validan
        if (index >= 0 && index < objects.Length)
        {
            objects[index].SetActive(true);
            // Postavljamo objekt na poziciju roditeljskog GameObjecta uz dodatak offseta
            objects[index].transform.position = transform.position;
        }
    }


    // Metoda za skrivanje pojedinaènih objekata
    public void HideObject()
    {
        // Iskljuèujemo sve objekte
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }
}
