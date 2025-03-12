using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] private float pipeSpeed;
    void Update()
    {
        PipeMovement(); 
    }

    private void PipeMovement()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;

        if(transform.position.x < -13.5f)
        {
            Destroy(gameObject);
        }
    }
}
