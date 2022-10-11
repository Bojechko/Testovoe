using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    private int _speed = 0;
    private int _distance = 0;

    private Vector3 _startPoint;

    public void SetParameters(int speed, int distance)
    {
        _speed = speed;
        _distance = distance;
    }

    private void Start()
    {
        _startPoint = transform.position;
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward *_speed * Time.deltaTime);
        if (transform.position.z >= _startPoint.z + _distance)
        {
            Destroy(gameObject);
        }
    }
}
