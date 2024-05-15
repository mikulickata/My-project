using UnityEngine;

public class ReplaceObject : MonoBehaviour
{
    public GameObject[] objects; // Niz objekata koji �e biti upravljani
    public Vector3 offsetFromParent = Vector3.zero; // Pomak od roditeljskog GameObjecta

    private void Start()
    {
        // Na po�etku isklju�ujemo sve objekte
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }

    // Metoda za prikazivanje odre�enog objekta
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


    // Metoda za skrivanje pojedina�nih objekata
    public void HideObject()
    {
        // Isklju�ujemo sve objekte
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }
}
