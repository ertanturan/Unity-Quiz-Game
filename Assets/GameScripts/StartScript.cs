using System.Collections;
using UnityEngine;

public class StartScript : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("MoveScreen");
    }

    void Update()
    {

    }
    IEnumerator MoveScreen()
    {
        yield return new WaitForSeconds(4);
        Application.LoadLevel("Title");
    }


}
