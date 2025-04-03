using UnityEngine;

public class Clone: MonoBehaviour
{
    GameObject mother;
    GameObject[] Clones;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mother = GameObject.Find("Firefly"); //  "Collectibles" is the name in the scene

        Clones = new GameObject[15];
        //add for loop to populate with 10-15 firefly objects (prefab?) near start
        for (int i = 0; i < 15; i++)
        {
         Clones[i] = GameObject.Instantiate(mother);
          Clones[i].transform.position = new Vector3(Random.Range(-2f, 2f), 2, i);
        }
    } 

    void OnMove(){
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 15; i++)
        {
          Clones[i].transform.position = new Vector3(Random.Range(-1f, 1f), 2, i);
        }
    }
}
