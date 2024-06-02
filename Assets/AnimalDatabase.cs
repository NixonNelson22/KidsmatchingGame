using System;
using System.Collections.Generic;
using UnityEngine;
// data template
[CreateAssetMenu]
public class AnimalDatabase : ScriptableObject
{   
    public List<AnimalData> animalData;   
}
[Serializable]
public class AnimalData
{
    //animal name
    [field:SerializeField]
    public String Name {get; private set;}

    //description
    [field:SerializeField]
    public String description {get; private set;}

    //category
    [field:SerializeField]
    public String[] categories {get; private set;}

    [field:SerializeField]
    public GameObject Prefab {get; private set;}
    
    [field:SerializeField]
    public Vector2 Position {get; set;}

}