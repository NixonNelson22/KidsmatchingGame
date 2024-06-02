using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public AnimalDatabase animal;
    public Vector2[] CardPlacementVector = new Vector2[]    {new Vector2(-7,3),new Vector2(-3,3),new Vector2(-1,3),new Vector2(2,3),
                                                             new Vector2(-7,1),new Vector2(-3,1),new Vector2(-1,1),new Vector2(2,1)};
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Spawn()
    {
        List<GameObject> temp = new List<GameObject>(); // temp data for duplicate check
        temp.Capacity = 7;
        
        for (int j = 0; j < CardPlacementVector.Length; j++)
        {
            int i = UnityEngine.Random.Range(0,17);
            AnimalData item = animal.animalData[i];
            
            Debug.Log(item.Name);

            bool duplicatefound = false;

            foreach (GameObject tempitem in temp)
            {
                if(tempitem.gameObject.name == item.Prefab.gameObject.name){
                    duplicatefound = true;
                }
            }
            if (duplicatefound)
            {
                continue;
            }
            Instantiate(item.Prefab,new Vector3(CardPlacementVector[j].x,CardPlacementVector[j].y,0),Quaternion.identity);
            animal.animalData[i].Position = CardPlacementVector[j];
            Debug.Log(j);
            temp[j] = item.Prefab;
            
        }
    }

}
