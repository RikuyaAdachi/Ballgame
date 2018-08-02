using UnityEngine;
using UnityEngine.SceneManagement;

public class outareaScript : MonoBehaviour
{
    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == "Player")
        {
            SceneManager.LoadScene(0);
            //SceneManager.LoadScene("自然を作成する");
        }
    }
}