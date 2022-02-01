using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public int waitTime;
    void Start()
    {
        StartCoroutine(waitForLevel());
    }
    IEnumerator waitForLevel()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);
    }

}
