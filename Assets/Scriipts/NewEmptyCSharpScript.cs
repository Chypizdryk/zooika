using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var otherSuika = other.gameObject.GetComponent<NewEmptyCSharpScript>();
        //^ var deklariert eine Variable, dessen Typ vom Kontext ermittrlt wird.
        // In diesem fall "NewEmpty"
        //                          ^Wir holen vom anderen Collider das gameObject
        //                                  ^Und holen uns davon einen Component vom Typen
        if (otherSuika == null)//Also wenn das andere Object keien Suika ball hat 
        {
            return; 
        }
        Debug.Log("Ich habe einen Ball gebührt!");
    }
}
