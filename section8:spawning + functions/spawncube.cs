
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
 // Spawn Some GameObject at a specific point in the 3d world

 private Vector3 V3_tripleZero = new Vector3(0, 0, 0); // where in the 3d world do we want to spawn our gameobject?
 [SerializeField] public GameObject _myPrefabTarget; // what is the game object we want to spawn at our spawn point? 


    void Start()
    {
       
        
    GameObject someCube = GameObject.CreatePrimitive(PrimitiveType.Cube); //primative cube
    Instantiate(someCube, V3_tripleZero, Quaternion.identity); 

    }


}
